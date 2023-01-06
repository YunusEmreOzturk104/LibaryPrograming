using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibaryPrograming.Models.Entity;
namespace LibaryPrograming.Controllers
{
    public class UyeController : Controller
    {
        // GET: Uye
        KutuphaneDbEntities db = new KutuphaneDbEntities();

        public ActionResult Index(string p)
        {
            var degerler = from d in db.TBLUYEs select d;
            if (!string.IsNullOrEmpty(p))
            {
                degerler = degerler.Where(m => m.UYEAD.Contains(p));
            }
            return View(degerler.ToList());
            //var degerler = db.TBLUYEs.ToList();
            //return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniUye()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniUye(TBLUYE p1)
        {
            if (!ModelState.IsValid)
            {
                return View("YeniUye");
            }
            db.TBLUYEs.Add(p1);
            db.SaveChanges();
            return View();
        }
        public ActionResult SIL(int id)
        {
            var uye = db.TBLUYEs.Find(id);
            db.TBLUYEs.Remove(uye);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UyeGetir(int id)
        {
            var uye = db.TBLUYEs.Find(id);
            return View("UyeGetir", uye);
        }
        public ActionResult Guncelle(TBLUYE p1)
        {
            var uye = db.TBLUYEs.Find(p1.UYEID);
            uye.UYEAD = p1.UYEAD;
            uye.UYESOYAD = p1.UYESOYAD;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}