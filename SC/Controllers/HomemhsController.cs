using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SC.Controllers
{
    public class HomemhsController : Controller
    {
        public IActionResult Index()
        {
            var iduser = HttpContext.Session.GetString("iduser");
            ViewBag.idusr = iduser;
            return View();
        }
    }
}
