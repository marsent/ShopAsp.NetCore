using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopAsp.NetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BC = BCrypt.Net.BCrypt;

namespace ShopAsp.NetCore.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly AppDbContext _db;
        public AuthenticationController(AppDbContext db)
        {
            _db = db;
        }
        //[BindProperty]
        //public User User { get; set; }
        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("IsLogin") != 1) return RedirectToAction("Login");
            if (HttpContext.Session.GetInt32("Role") == 0) return RedirectToAction("Index", "Customer");
            if (HttpContext.Session.GetInt32("Role") == 1) return RedirectToAction("Index", "Admin");
            ViewBag.Id = HttpContext.Session.GetInt32("Id");
            ViewBag.Name = HttpContext.Session.GetString("FullName");
            ViewBag.Email = HttpContext.Session.GetString("Email");
            ViewBag.Role = HttpContext.Session.GetInt32("Role"); ;
            return View();
        }
        public IActionResult Register()
        {
            if (HttpContext.Session.GetInt32("IsLogin") == 1) return RedirectToAction("Index");
            ViewData["Title"] = "Đăng kí";
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(User User)
        {
            if (HttpContext.Session.GetInt32("IsLogin") == 1) return RedirectToAction("Index");
            if (HttpContext.Session.GetString("Fullname") != null)
            {
                return RedirectToAction("Index", "Customer");
            }
            else if (ModelState.IsValid)
            {
                var check = _db.Users.FirstOrDefault(u => u.Email == User.Email);
                if (check == null)
                {
                    User.Password = BC.HashPassword(User.Password);
                    _db.Add(User);
                    _db.SaveChanges();
                    return RedirectToAction("Login");
                }
                else
                {
                    ModelState.AddModelError("Email", "Email đã được sử dụng");
                    //ViewBag.error = "Email đã được sử dụng";
                    return View();
                }
            }
            return View();
        }
        public IActionResult Login()
        {
            if (HttpContext.Session.GetInt32("IsLogin") == 1) return RedirectToAction("Index");
            ViewData["Title"] = "Đăng nhập";

            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public IActionResult Login(string email, string password)
        {
            if (HttpContext.Session.GetInt32("IsLogin") == 1) return RedirectToAction("Index");
            var account = _db.Users.FirstOrDefault(u => u.Email == email);
            if (account != null && BC.Verify(password, account.Password))
            {
                HttpContext.Session.SetInt32("IsLogin", 1);
                HttpContext.Session.SetInt32("Id", account.Id);
                HttpContext.Session.SetString("FullName", (string)(account.LastName + " " + account.FirstName));
                HttpContext.Session.SetString("Email", account.Email);
                HttpContext.Session.SetInt32("Role", account.Role);
                HttpContext.Response.Cookies.Append("Username", account.LastName + " " + account.FirstName);
                HttpContext.Response.Cookies.Append("Role", account.Role.ToString());
                return RedirectToAction("Index");
            }

            //ViewBag.error = "Sai tài khoản hoặc mật khẩu";
            ModelState.AddModelError("Password", "Sai tài khoản hoặc mật khẩu");
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            HttpContext.Response.Cookies.Delete("Username");
            HttpContext.Response.Cookies.Delete("Role");
            return RedirectToAction("Index","Customer");
        }
    }
}
