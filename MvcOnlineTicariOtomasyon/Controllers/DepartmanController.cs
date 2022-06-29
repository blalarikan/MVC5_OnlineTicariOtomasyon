using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcOnlineTicariOtomasyon.Models.Context;
using MvcOnlineTicariOtomasyon.Models.Entities;



namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class DepartmanController : Controller
    {
        Context c = new Context();
        // GET: Departman
        public ActionResult Index()
        {
            var degerler = c.Departmanlar.Where(x=>x.Status==true).ToList();
            return View(degerler);
        }


        [HttpGet]
        public ActionResult DepartmanAdd()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DepartmanAdd(Departman d)
        {
            c.Departmanlar.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult DepartmanSil(int id)
        {
            var deger = c.Departmanlar.Find(id);
            deger.Status = false;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DepartmanGetir(int id)
        {
            var deger = c.Departmanlar.Find(id);
            return View("DepartmanGetir", deger);
        }

        public ActionResult DepartmanGuncelle(Departman dep)
        {
            var dept = c.Departmanlar.Find(dep.DepartmanId);
            dept.DepartmanName = dep.DepartmanName;
            c.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult DepartmanDetay(int id)
        {
            var degerler = c.Employers.Where(x => x.DepartmanId == id).ToList();
            var dgr = c.Departmanlar.Where(x => x.DepartmanId == id).Select(y => y.DepartmanName).SingleOrDefault();
            ViewBag.d = dgr;
            return View(degerler);
        }

        public ActionResult DepartmanPersonelSatis(int id)
        {
            var degerler = c.SatisHareketler.Where(x => x.EmployerId == id).ToList();
            var per = c.Employers.Where(x => x.EmployerId == id).Select(y => y.FirstName +" "+ y.LastName).SingleOrDefault();
            ViewBag.dpers = per;
            return View(degerler);
        }
    }
}