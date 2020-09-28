using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BakeryProjects.Controllers
{
    public class DiffController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
