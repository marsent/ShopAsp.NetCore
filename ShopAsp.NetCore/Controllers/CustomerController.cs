using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
/*using ShopAsp.NetCore.Data;*/
using ShopAsp.NetCore.Models;
using Microsoft.AspNetCore.Authorization;


namespace ShopAsp.NetCore.Controllers
{
    public class CustomerController : Controller
    {
        private readonly AppDbContext _context;
        public CustomerController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {

            if (HttpContext.Session.GetInt32("IsLogin") != 1)
            {
                ViewData["UserId"] = -1;
            }
            else
            {
                ViewData["UserId"] = HttpContext.Session.GetInt32("Id");
            }

            var products = from p in _context.Products
                         select p;

            ViewData["OutstandingProducts"] = products.Where(s => s.OutstandingProducts == true);

            ViewData["HotProduct"] = products.Where(s => s.HotProduct == true);

            ViewData["Samsung"] = products.Where(s => s.Brand == "Samsung");

            ViewData["Apple"] = products.Where(s => s.Brand == "Apple");

            return View();
        }
    }
    
    
    
    

}
