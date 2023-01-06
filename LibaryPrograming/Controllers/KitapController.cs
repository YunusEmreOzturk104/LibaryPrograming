using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibaryPrograming.Models.Entity;
namespace LibaryPrograming.Controllers
{
    public class KitapController : Controller
    {
        // GET: Urun
        KutuphaneDbEntities db = new KutuphaneDbEntities();
        public ActionResult Index()
        {
            var degerler = db.TBLKITAPLARs.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult KıtapEkle()
        {
            List<SelectListItem> degerler = (from i in db.TBLKATEGORIs.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.KATEGORIAD,
                                                 Value = i.KATEGORIID.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
            List<SelectListItem> degerler2 = (from i in db.TBLYAZARs.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.YAZARAD,
                                                 Value = i.YAZARID.ToString()
                                             }).ToList();
            ViewBag.dgr2 = degerler2;
            return View();
        }
        [HttpPost]
        public ActionResult KıtapEkle(TBLKITAPLAR p1)
        {
            var ktg = db.TBLKATEGORIs.Where(m => m.KATEGORIID == p1.TBLKATEGORI.KATEGORIID).FirstOrDefault();
            p1.TBLKATEGORI = ktg;
            var ktg2 = db.TBLYAZARs.Where(m => m.YAZARID == p1.TBLYAZAR.YAZARID).FirstOrDefault();
            p1.TBLYAZAR = ktg2;
            db.TBLKITAPLARs.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult SIL(int id)
        {
            var kıtap = db.TBLKITAPLARs.Find(id);
            db.TBLKITAPLARs.Remove(kıtap);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult KitapGetir(int id)
        {
            var ktp = db.TBLKITAPLARs.Find(id);

            List<SelectListItem> degerler = (from i in db.TBLKATEGORIs.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.KATEGORIAD,
                                                 Value = i.KATEGORIID.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
            List<SelectListItem> degerler2 = (from i in db.TBLYAZARs.ToList()
                                              select new SelectListItem
                                              {
                                                  Text = i.YAZARAD,
                                                  Value = i.YAZARID.ToString()
                                              }).ToList();
            ViewBag.dgr2 = degerler2;
            return View("KitapGetir", ktp);
        }
        public ActionResult Guncelle(TBLKITAPLAR p)
        {
            var ktp = db.TBLKITAPLARs.Find(p.KITAPID);
            ktp.KITAPAD = p.KITAPAD;
            ktp.ADET = p.ADET;
            //ktp.KITAPKATEGORİ = p.KITAPKATEGORİ;
            //ktp.KİTAPYAZAR = p.KİTAPYAZAR;
            var ktg = db.TBLKATEGORIs.Where(m => m.KATEGORIID == p.TBLKATEGORI.KATEGORIID).FirstOrDefault();
            ktp.KITAPKATEGORİ = ktg.KATEGORIID;
            var ktg2 = db.TBLYAZARs.Where(m => m.YAZARID == p.TBLYAZAR.YAZARID).FirstOrDefault();
            ktp.KİTAPYAZAR = ktg2.YAZARID;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}