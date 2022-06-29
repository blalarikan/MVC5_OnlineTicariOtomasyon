using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcOnlineTicariOtomasyon.Models.Context;
using MvcOnlineTicariOtomasyon.Models.Entities;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class CariController : Controller
    {
        Context c = new Context();

        // GET: Cari
        public ActionResult Index()
        {
            var degerler = c.Cariler.Where(x=>x.Status==true).ToList();
            return View(degerler);

        }

        [HttpGet]
        public ActionResult CariAdd()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CariAdd(Cari cari)
        {
            cari.Status = true;
            c.Cariler.Add(cari);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult CariSil(int id)
        {
            var deger = c.Cariler.Find(id);
            deger.Status = false;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

