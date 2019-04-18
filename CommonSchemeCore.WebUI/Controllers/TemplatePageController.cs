using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CommonSchemeCore.WebUI.Controllers
{
    public class TemplatePageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome() {
            return View();
        }
    }
}