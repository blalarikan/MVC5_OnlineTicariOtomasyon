using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using MvcOnlineTicariOtomasyon.Models.Context;
using MvcOnlineTicariOtomasyon.Models.Entities;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        Context c = new Context();

        public ActionResult Index()
        {
            var urunler = c.Products.Where(x=>x.Status==true).ToList();
            return View(urunler);
        }

        [HttpGet]
        public ActionResult ProductAdd()
        {
            List<SelectListItem> deger1 = (from x in c.Categories.ToList()
                select new SelectListItem
                {
                    Text = x.CategoryName,
                    Value = x.CategoryId.ToString()
                }).ToList();
            ViewBag.dgr1 = deger1;
                return View();
        }

        [HttpPost]
        public ActionResult ProductAdd(Product product)
        {

            c.Products.Add(product);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult UrunSil(int id)
        {
            var deger = c.Products.Find(id);
            deger.Status = false;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult UrunGetir(int id)
        {
            List<SelectListItem> deger1 = (from x in c.Categories.ToList()
                select new SelectListItem
                {
                    Text = x.CategoryName,
                    Value = x.CategoryId.ToString()
                }).ToList();
            ViewBag.dgr1 = deger1;
            var urundeger = c.Products.Find(id);
            return View("UrunGetir", urundeger);
        }

        public ActionResult UrunGuncelle(Product p)
        {
            var urun = c.Products.Find(p.ProductId);
            urun.PurchasePrice = p.PurchasePrice;
            urun.Status = p.Status;
            urun.CategoryId = p.CategoryId;
            urun.Brand = p.Brand;
            urun.SalePrice = p.SalePrice;
            urun.Stock = p.Stock;
            urun.Name = p.Name;
            urun.Image = p.Image;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}