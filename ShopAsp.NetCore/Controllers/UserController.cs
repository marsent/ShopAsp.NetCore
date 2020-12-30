using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopAsp.NetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BC = BCrypt.Net.BCrypt;

namespace ShopAsp.NetCore.Controllers
{
    public class UserController : Controller
    {
        private readonly AppDbContext _db;

        public UserController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("IsLogin") != 1) return RedirectToAction("Login", "Authentication");
            var user = _db.Users.FirstOrDefault(u => u.Id == HttpContext.Session.GetInt32("Id"));

            return View(user);
        }
        [HttpPost]
        public async Task<IActionResult> Update(User user)
        {

            var UserFromDb = _db.Users.FirstOrDefault(u => u.Id == HttpContext.Session.GetInt32("Id"));
            UserFromDb.Email = user.Email;
            UserFromDb.FirstName = user.FirstName;
            UserFromDb.LastName = user.LastName;
            UserFromDb.Address = user.Address;
            HttpContext.Session.SetString("FullName", user.LastName + user.FirstName);
            UserFromDb.ConfirmPassword = UserFromDb.Password;
            _db.Users.Update(UserFromDb);
            await _db.SaveChangesAsync();
            ViewBag.Success = true;


            return RedirectToAction("Index");
        }
        public IActionResult UpdatePassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdatePassword(UpdatePassword data)
        {
            if (ModelState.IsValid)
            {
                var UserFromDb = _db.Users.FirstOrDefault(u => u.Id == HttpContext.Session.GetInt32("Id"));

                if (BC.Verify(data.OldPassword, UserFromDb.Password))
                {
                    UserFromDb.Password = BC.HashPassword(data.NewPassword);
                    _db.Users.Update(UserFromDb);
                    await _db.SaveChangesAsync();
                    ViewBag.Success = true;
                }
                else
                {
                    ModelState.AddModelError("OldPassword", "Sai mật khẩu");
                    return View();
                }
            }
            return View();
        }

    }
}
