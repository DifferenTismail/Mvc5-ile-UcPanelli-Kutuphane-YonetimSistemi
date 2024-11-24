using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcKutuphane.Models.Entity;
namespace MvcKutuphane.Controllers
{
    public class KategoriController : Controller
    {
        DbKutuphaneEntities db = new DbKutuphaneEntities();
        public ActionResult Index()
        {
            var values = db.Tbl_Kategori.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult YeniKategori()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniKategori(Tbl_Kategori kategori)
        {
            db.Tbl_Kategori.Add(kategori);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult KategoriSil(int id)
        {
            var value = db.Tbl_Kategori.Find(id);
            db.Tbl_Kategori.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult KategoriGuncelle(int id)
        {
            var value = db.Tbl_Kategori.Find(id);
            return View("KategoriGuncelle", value);
        }
        [HttpPost]
        public ActionResult KategoriGuncelle(Tbl_Kategori kategori)
        {
            var value = db.Tbl_Kategori.Find(kategori.ID);
            value.Ad = kategori.Ad;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}