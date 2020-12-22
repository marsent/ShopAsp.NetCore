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
        public AdminController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {

            return View();

        }
        public IActionResult Upsert(int? id)
        {
            Product = new Product();
            if (id == null)
            {
                //create
                return View(Product);
            }
            //update
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

            if (ModelState.IsValid)
            {
                if (Product.ImageFile != null)
                {
                    if (Product.ImageFile.Length > 0)
                    {

                        string fileExtension = Path.GetExtension(Product.ImageFile.FileName);
                        string UniqueFileName = Convert.ToString(Guid.NewGuid());
                        string newFileName = String.Concat(UniqueFileName, fileExtension);
                        var dir = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Public\\Images")).Root;
                        var path = dir + $@"\{newFileName}";
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

        #region API Calls

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Json(new { data = await _db.Products.ToListAsync() });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
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
        #endregion
    }
}
