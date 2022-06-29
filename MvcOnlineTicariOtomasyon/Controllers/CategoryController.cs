using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using MvcOnlineTicariOtomasyon.Models.Entities;
using Context = MvcOnlineTicariOtomasyon.Models.Context.Context;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class CategoryController : Controller
    {
        Context c = new Context();

        // GET: Category
        public ActionResult Index()
        {
            var degerler = c.Categories.ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult KategoriAdd()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult KategoriAdd(Category category)
        {

            c.Categories.Add(category);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult KategoriSil(int id)
        {
            var kate = c.Categories.Find(id);
            c.Categories.Remove(kate);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult KategoriGetir(int id)
        {
            var kategori = c.Categories.Find(id);
            return View("KategoriGetir", kategori);
        }

        public ActionResult KategoriGuncelle(Category category)
        {
            var ktgr = c.Categories.Find(category.CategoryId);
            ktgr.CategoryName = category.CategoryName;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}