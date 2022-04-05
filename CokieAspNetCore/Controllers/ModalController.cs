using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CokieAspNetCore.Controllers
{
    public class ModalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
