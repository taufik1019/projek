using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SC.Context;
using SC.Repositories.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SC.Controllers
{
    public class KeluhanmhsController : Controller
    {
        KeluhanRepository KeluhanRepository;

        MhsRepository MhsRepository;


        public KeluhanmhsController(KeluhanRepository KeluhanRepository, MhsRepository MhsRepository)
        {
            this.KeluhanRepository = KeluhanRepository;
            this.MhsRepository = MhsRepository;
        }

      
        //public IActionResult Index()
        //{
            
        //    var iduser = HttpContext.Session.GetString("iduser");
        //    //var iduser = .httpContextAccessor.HttpContext.Session("iduser");
        //    //var usr = this.Iduser;
        //    if (iduser != null)
        //    {
        //        //var usr = iduser.First();
        //       var data1 = MhsRepository.getmhsid(iduser);
        //        //ViewBag.idus

        //       var data = KeluhanRepository.getmhs(data1.MhsId);
        //       //var data = "";
        //       return View(data);
        //    } else
        //    {
        //        var data = "";
        //        return View(data);
        //    }
            
        //}

        //public IActionResult MasukanKeluhan(Models.Keluhan keluhan)
        //{
        //    var datenowidn = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        //    ViewBag.datenowidn = datenowidn;
        //    var iduser = HttpContext.Session.GetString("iduser");
        //    var data1 = MhsRepository.getmhsid(iduser);
        //    ViewBag.iduser = data1.MhsId;
        //    if (ModelState.IsValid)
        //    {

        //        var result = KeluhanRepository.Post(keluhan);
        //        if (result > 0)
        //            return RedirectToAction("Index");
        //    }
        //    return View();
        //}

        //public IActionResult MasukanKeluhan()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult Keluhanexec(ViewModels.KeluhanMhs keluhanMhs)
        //{
        //    var iduser = HttpContext.Session.GetString("iduser");
        //    if (iduser != null)
        //    {
        //        var data1 = MhsRepository.getmhsid(iduser);
        //        //var result = KeluhanRepository.Post(keluhan);
        //        //if (result > 0)
        //        //{
        //        //    return RedirectToAction("Index", "Keluhanmhs");
        //        //}
        //    }
        //    return View();
        //}
    }
}
