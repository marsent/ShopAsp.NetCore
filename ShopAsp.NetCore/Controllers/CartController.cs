using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using ShopAsp.NetCore.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ShopAsp.NetCore.Controllers;

namespace ShopAsp.NetCore.Controllers
{

    public class CartController : Controller
    {
        private readonly AppDbContext _context;
        public CartController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var products = from p in _context.Products
                           select p;

            ViewData["HotProducts"] = products.Where(s => s.HotProduct == true);

            if (HttpContext.Session.GetString("FullName") != null)
            {
                var cartItems = from cart in _context.Carts
                                join product in _context.Products on cart.ProductId equals product.Id
                                select new CartItem { Product = product, Cart = cart };

                cartItems = cartItems.Where(i=> i.Cart.UserId == HttpContext.Session.GetInt32("Id"));

                ViewData["CartItems"] = cartItems;
                ViewData["UserId"] = HttpContext.Session.GetInt32("Id");
                long total = cartItems.Select(s => s.Cart.Quantity * s.Product.Price).Sum();
                ViewData["Total"] = (total > 10000000) ? total : total + 100000;
                ViewBag.Quantity = cartItems.Select(i => i.Cart.Quantity).Sum();
                ViewData["Message"] = (total > 10000000) ? "Đơn hàng trên 10 triệu được miễn phí vận chuyển" : "Phí vận chuyển đơn hàng là 100,000đ";
            }
            else
            {
                TempData["LoginRequired"] = "Bạn cần phải đăng nhập để xem giỏ hàng";
                return RedirectToAction("Login", "Authentication");
            }

            return View();
        }

        public string GetTotalItem()
        {
            if (HttpContext.Session.GetString("FullName") != null)
            {
                var cartItems = from cart in _context.Carts
                                select cart;

                return cartItems.Where(s => s.UserId == HttpContext.Session.GetInt32("Id")).Select(s => s.Quantity).Sum().ToString();
            }
            else
            {
                List<string> cart = new List<string>();
                if (HttpContext.Request.Cookies["tyMobileUser"] != null)
                {
                    cart = HttpContext.Request.Cookies["tyMobileUser"].Split(',').ToList();
                }
                return cart.Count.ToString();
            }
        }

        public void ClearCookies()
        {
            HttpContext.Response.Cookies.Delete("tyMobileUser");
        }

        [HttpPost]
        public string Add(int userId, int itemId, int quantity)
        {
            if (userId != -1)
            {
                var items = from m in _context.Carts
                            select m;

                var cart = items.FirstOrDefault(x => x.UserId == userId && x.ProductId == itemId);

                if (cart == null)
                {
                    Cart myCart = new Cart();
                    myCart.UserId = userId;
                    myCart.ProductId = itemId;
                    myCart.Quantity = quantity;
                    _context.Add(myCart);
                }
                else
                {
                    if (cart.Quantity + quantity <= 0)
                    {
                        _context.Remove(cart);
                    }
                    else
                    {
                        cart.Quantity += quantity;
                        _context.Update(cart);
                    }
                }

                try
                {
                    _context.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    _context.SaveChanges();
                }
            }
            else
            {
                List<string> cart = new List<string>();
                if (HttpContext.Request.Cookies["tyMobileUser"] != null)
                {
                    cart = HttpContext.Request.Cookies["tyMobileUser"].Split(',').ToList();
                }
                string item = itemId.ToString() + "-" + quantity.ToString();
                cart.Add(item);
                string combindedCart = string.Join(",", cart);
                CookieOptions cookieOptions = new CookieOptions();
                cookieOptions.Expires = new DateTimeOffset(DateTime.Now.AddDays(7));
                HttpContext.Response.Cookies.Append("tyMobileUser", combindedCart, cookieOptions);
                return cart.Count.ToString();
            }
            return GetTotalItem();
        }

        public async Task<IActionResult> CheckOut()
        {
            if (HttpContext.Session.GetInt32("IsLogin") != 1) return RedirectToAction("Login", "Authentication");

            var cartItems = from cart in _context.Carts
                            join product in _context.Products on cart.ProductId equals product.Id
                            select new CartItem { Product = product, Cart = cart };

            cartItems = cartItems.Where(i => i.Cart.UserId == HttpContext.Session.GetInt32("Id"));

            ViewData["CartItems"] = cartItems;
            ViewData["UserId"] = HttpContext.Session.GetInt32("Id");
            int total = cartItems.Select(s => s.Cart.Quantity * s.Product.Price).Sum();
            ViewData["Total"] = (total > 10000000) ? total : total + 100000;
            ViewBag.Quantity = cartItems.Select(i => i.Cart.Quantity).Sum();
            ViewData["ShippingCost"] = (total > 10000000) ? "Đơn hàng trên 10 triệu được miễn phí vận chuyển" : "Phí vận chuyển đơn hàng là 100,000đ";

            var user = _context.Users.FirstOrDefault(u => u.Id == HttpContext.Session.GetInt32("Id"));

            Bill bill = new Bill();

            bill.User = user;
            bill.Receiver = user.LastName + " " + user.FirstName;
            bill.UserId = user.Id;
            bill.Total = (total > 10000000) ? total : total + 100000;


            return View(bill);
        }

        [HttpPost]
        public async Task<IActionResult> ConfirmCheckOut(Bill b)
        {

            if (HttpContext.Session.GetInt32("IsLogin") != 1) return RedirectToAction("Login", "Authentication");
            Bill bill = new Bill();
            DateTime dt = DateTime.Now;
            bill.Date = dt;
            bill.UserId = b.UserId;
            bill.Status = "Chưa vận chuyển";
            bill.Total = b.Total;
            bill.Pay = "Chưa thanh toán";
            bill.Address = $"{b.Address}, {b.District}, {b.Province}";
            bill.District = b.District;
            bill.Province = b.Province;
            bill.Phone = b.Phone;
            bill.Receiver = b.Receiver;

            _context.Bills.Add(bill);

            await _context.SaveChangesAsync();
            var bills = from bi in _context.Bills select bi;
            Bill currentBill = bills.FirstOrDefault(i => i.Date == dt);
            var cartItems = from cart in _context.Carts
                            join product in _context.Products on cart.ProductId equals product.Id
                            select new CartItem { Product = product, Cart = cart };

            cartItems = cartItems.Where(i => i.Cart.UserId == HttpContext.Session.GetInt32("Id"));

            List<CartItem> listCartItems = cartItems.ToList();

            listCartItems.ForEach((i) => {
                BillDetail bd = new BillDetail();
                bd.BillId = currentBill.BillId;
                bd.ProductId = i.Product.Id;
                bd.quantity = i.Cart.Quantity;
                bd.TotalPrice = i.Product.Price * i.Cart.Quantity;
                _context.BillDetails.Add(bd);
                _context.SaveChanges();
            });

            return RedirectToAction("CheckOutSuccess");
        }

        public ActionResult CheckOutSuccess()
        {
            if (HttpContext.Session.GetInt32("IsLogin") != 1) return RedirectToAction("Login", "Authentication");
            var ci = _context.Carts.Where(u => u.UserId == HttpContext.Session.GetInt32("Id")).ToList();
            ci.ForEach(i =>
            {
                _context.Remove(i);
            });
            _context.SaveChanges();
            return View();
        }
    }
}

