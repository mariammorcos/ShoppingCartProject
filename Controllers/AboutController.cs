using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ShoppingProject.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
    }
}