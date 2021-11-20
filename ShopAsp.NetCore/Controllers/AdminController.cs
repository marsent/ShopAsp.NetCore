using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using ShopAsp.NetCore.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAsp.NetCore.Controllers
{
    public class AdminController : Controller
    {
        private readonly AppDbContext _db;
        [BindProperty]
        public Product Product { get; set; }
        [BindProperty]
        public Bill Bill { get; set; }
        public AdminController(AppDbContext db)
        {
            _db = db;
        }
       
        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("IsLogin") != 1) return RedirectToAction("Login", "Authentication");
            if (HttpContext.Session.GetInt32("Role") == 0) return RedirectToAction("Index", "Customer");
            ViewData["FullName"]=HttpContext.Session.GetString("FullName");
            ViewData["Title"] = "Quản lý sản phẩm";
            return View();
        }

        public IActionResult Invoices()
        {
            if (HttpContext.Session.GetInt32("IsLogin") != 1) return RedirectToAction("Login", "Authentication");
            if (HttpContext.Session.GetInt32("Role") == 0) return RedirectToAction("Index", "Customer");
            ViewData["FullName"] = HttpContext.Session.GetString("FullName");
            ViewData["Title"] = "Quản lý hóa đơn";
            return View();
        }

        public IActionResult Upsert(int? id)
        {
            if (HttpContext.Session.GetInt32("IsLogin") != 1) return RedirectToAction("Login", "Authentication");
            if (HttpContext.Session.GetInt32("Role") == 0) return RedirectToAction("Index", "Customer");
            Product = new Product();
            if (id == null)
            {
                //create
                ViewData["Title"] = "Thêm sản phẩm";
                return View(Product);
            }
            //update
            ViewData["Title"] = "Cập nhật sản phẩm";
            Product = _db.Products.FirstOrDefault(u => u.Id == id);
            if (Product == null)
            {
                return NotFound();
            }
            return View(Product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpsertAsync()
        {
            if (HttpContext.Session.GetInt32("IsLogin") != 1) return RedirectToAction("Login", "Authentication");
            if (HttpContext.Session.GetInt32("Role") == 0) return RedirectToAction("Index", "Customer");
            if (ModelState.IsValid)
            {
                if (Product.ImageFile != null)
                {
                    if (Product.ImageFile.Length > 0)
                    {

                        string fileExtension = Path.GetExtension(Product.ImageFile.FileName);
                        string UniqueFileName = Convert.ToString(Guid.NewGuid());
                        string newFileName = String.Concat(UniqueFileName, fileExtension);
                        var dir = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "assets/products")).Root;
                        var path = dir + $@"{newFileName}";
                        using (var fileStream = new FileStream(path, FileMode.Create))
                        {
                            await Product.ImageFile.CopyToAsync(fileStream);
                        }
                        if (Product.ImageUrl != newFileName && Product.ImageUrl != null)
                        {
                            if (System.IO.File.Exists(dir + $@"\{Product.ImageUrl}"))
                            {
                                System.IO.File.Delete(dir + $@"\{Product.ImageUrl}");
                            }
                        }
                        Product.ImageUrl = newFileName;
                    }
                }
                if (Product.Id == 0)
                {
                    //create
                    Product.DateCreate = Product.DateUpdate = DateTime.Now;
                    _db.Products.Add(Product);
                }
                else
                {
                    Product.DateUpdate = DateTime.Now;
                    _db.Products.Update(Product);
                }
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Product);
        }

        public IActionResult UpsertBill(int? id)
        {
            if (HttpContext.Session.GetInt32("IsLogin") != 1) return RedirectToAction("Login", "Authentication");
            if (HttpContext.Session.GetInt32("Role") == 0) return RedirectToAction("Index", "Customer");
            Bill = new Bill();
            ViewData["Title"] = "Chỉnh sửa hóa đơn";
            Bill = _db.Bills.FirstOrDefault(u => u.BillId == id);
            if (Bill == null)
            {
                return NotFound();
            }
            Bill.Date = DateTime.Now;

            
            List<BillDetail> lbd = _db.BillDetails.Where(bd => bd.BillId == id).ToList();

            lbd.ForEach(i => {
                i.Product = _db.Products.FirstOrDefault(p => p.Id == i.ProductId);
            });

            Bill.BillDetails = lbd;

            return View(Bill);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpsertBillAsync()
        {
            if (HttpContext.Session.GetInt32("IsLogin") != 1) return RedirectToAction("Login", "Authentication");
            if (HttpContext.Session.GetInt32("Role") == 0) return RedirectToAction("Index", "Customer");
            _db.Bills.Update(Bill);
            _db.SaveChanges();
            return RedirectToAction("Invoices", "Admin");
            return View(Bill);
        }

        #region API Calls

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            if (HttpContext.Session.GetInt32("IsLogin") != 1) return RedirectToAction("Login", "Authentication");
            return Json(new { data = await _db.Products.ToListAsync() });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            if (HttpContext.Session.GetInt32("IsLogin") != 1) return RedirectToAction("Login", "Authentication");
            var productbookFromDb = await _db.Products.FirstOrDefaultAsync(u => u.Id == id);
            if (productbookFromDb == null)
            {
                return Json(new { success = false, message = "Error while Deleting" });
            }
            var path = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Public\\Images")).Root + $@"\{productbookFromDb.ImageUrl}";
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            _db.Products.Remove(productbookFromDb);
            await _db.SaveChangesAsync();
            return Json(new { success = true, message = "Delete successful" });
        }
        [HttpPost]
        public async Task<IActionResult> UpdateCheck(int id, bool data, string colName)
        {
            if (HttpContext.Session.GetInt32("IsLogin") != 1) return RedirectToAction("Login", "Authentication");
            var ProductFromDb = await _db.Products.FirstOrDefaultAsync(u => u.Id == id);
            if (ProductFromDb == null)
            {
                return Json(new { success = false, Message = "Không tìm thấy sản phẩm" });
            }
            if (colName == "HotProduct") ProductFromDb.HotProduct = data;
            if (colName == "OutstandingProducts") ProductFromDb.OutstandingProducts = data;
            _db.Products.Update(ProductFromDb);
            await _db.SaveChangesAsync();
            return Json(new { success = false, Message = "Cập nhật thành công" });
        }

        public async Task<IActionResult> GetAllInvoices()
        {
            if (HttpContext.Session.GetInt32("IsLogin") != 1) return RedirectToAction("Login", "Authentication");
            return Json(new { data = await _db.Bills.ToListAsync() });
        }

        public async Task<IActionResult> UserGetName(int userId)
        {
            if (HttpContext.Session.GetInt32("IsLogin") != 1) return RedirectToAction("Login", "Authentication");
            var user = await _db.Users.FirstOrDefaultAsync(u => u.Id == userId);
            if (user == null)
            {
                return Json(new { success = false, message = "Error" });
            }
            string name = user.LastName + " " + user.FirstName;
            return Json(new { success = true, message = name });
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBill(int id)
        {
            if (HttpContext.Session.GetInt32("IsLogin") != 1) return RedirectToAction("Login", "Authentication");
            var bill = await _db.Bills.FirstOrDefaultAsync(u => u.BillId == id);
            if (bill == null)
            {
                return Json(new { success = false, message = "Error while Deleting" });
            }
            var dt = _db.BillDetails.Where(u => u.BillId == id).ToList();
            dt.ForEach((i) =>
            {
                _db.BillDetails.Remove(i);
            });
            _db.Bills.Remove(bill);
            await _db.SaveChangesAsync();
            return Json(new { success = true, message = "Delete successful" });
        }

        #endregion
    }
}
