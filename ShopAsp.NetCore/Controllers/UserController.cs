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
            UserFromDb.ConfirmPassword = UserFromDb.Password;
            _db.Users.Update(UserFromDb);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
       
      
    }
}
