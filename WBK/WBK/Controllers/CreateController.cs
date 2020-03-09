using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WBK.Controllers
{
    public class CreateController : Controller
    {
        public IActionResult Survey()
        {
            return View();
        }
    }
}