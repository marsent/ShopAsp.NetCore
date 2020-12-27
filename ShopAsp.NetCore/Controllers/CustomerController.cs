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
        public IActionResult Index()
        {
            return View();
        }
        private readonly AppDbContext _db;
       
        //[BindProperty]
        //public User User { get; set; }
                      
     
    }
    
    
    
    

}
