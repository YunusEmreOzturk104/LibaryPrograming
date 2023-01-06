using LibaryPrograming.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibaryPrograming.Controllers
{
    public class OduncKıtaplarController : Controller
    {
        KutuphaneDbEntities db = new KutuphaneDbEntities();
        public ActionResult Index()
        {
            var degerler = db.TBLODUNCs.ToList();
            return View();
            
        }
        public ActionResult SIL(int id)
        {
            var odc = db.TBLODUNCs.Find(id);
            db.TBLODUNCs.Remove(odc);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult YeniOdunc()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniOdunc(TBLODUNC p)
        {
            db.TBLODUNCs.Add(p);
            db.SaveChanges();
            return View("Index");
        }
    }
}