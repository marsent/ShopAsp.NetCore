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
            // Use LINQ to get list of genres.
            

            var movies = from m in _context.Products
                         select m;

            ViewData["OutstandingProducts"] = movies.Where(s => s.OutstandingProducts == true);

            ViewData["HotProduct"] = movies.Where(s => s.HotProduct == true);

            ViewData["Samsung"] = movies.Where(s => s.Brand == "Samsung");

            ViewData["Apple"] = movies.Where(s => s.Brand == "Apple");

            return View();
        }


    }
    
    
    
    

}
