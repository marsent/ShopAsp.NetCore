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
                ViewData["Quantity"] = cartItems.Select(i => i.Cart.Quantity).Sum();
                long total = cartItems.Select(s => s.Cart.Quantity * s.Product.Price).Sum();
                ViewData["Total"] = total;

                ViewData["Message"] = (total > 5000000) ? "Đơn hàng của bạn được miễn phí vận chuyển" : "Phí vận chuyển đơn hàng là 50,000đ";
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
                if (HttpContext.Request.Cookies["user"] != null)
                {
                    cart = HttpContext.Request.Cookies["user"].Split(',').ToList();
                }
                return cart.Count.ToString();
            }
        }

        public void ClearCookies()
        {
            HttpContext.Response.Cookies.Delete("user");
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
                    if (-cart.Quantity == quantity)
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
                if (HttpContext.Request.Cookies["user"] != null)
                {
                    cart = HttpContext.Request.Cookies["user"].Split(',').ToList();
                }
                string item = itemId.ToString() + "-" + quantity.ToString();
                cart.Add(item);
                string combindedCart = string.Join(",", cart);
                CookieOptions cookieOptions = new CookieOptions();
                cookieOptions.Expires = new DateTimeOffset(DateTime.Now.AddDays(7));
                HttpContext.Response.Cookies.Append("user", combindedCart, cookieOptions);
                return cart.Count.ToString();
            }
            return GetTotalItem();
        }
    }
}

