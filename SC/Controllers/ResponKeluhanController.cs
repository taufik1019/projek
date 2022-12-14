using Microsoft.AspNetCore.Mvc;
using SC.Models;
using SC.Repositories.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SC.Controllers
{
    public class ResponKeluhanController : Controller
    {
         ResponKeluhanRepository ResponKeluhanRepository;

        public ResponKeluhanController(ResponKeluhanRepository ResponKeluhanRepository)
        {
            this.ResponKeluhanRepository = ResponKeluhanRepository;
        }

        public IActionResult Index()
        {

            var data = ResponKeluhanRepository.Get();
            return View(data);

        }

        // GET BY ID
        //GET
        public IActionResult Details(int id)
        {
            var data = ResponKeluhanRepository.Get(id);
            return View(data);
        }

        // CREATE 
        // GET
        public IActionResult Create()
        {
            return View();
        }
        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ResponKeluhan responKeluhan)
        {
            if (ModelState.IsValid)
            {

                var result = ResponKeluhanRepository.Post(responKeluhan);
                if (result > 0)
                    return RedirectToAction("Index");
            }
            return View();
        }
    }
}
