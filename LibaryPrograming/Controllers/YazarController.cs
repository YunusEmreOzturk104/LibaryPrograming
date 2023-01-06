using LibaryPrograming.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibaryPrograming.Controllers
{
    public class YazarController : Controller
    {
        // GET: Yazar
        KutuphaneDbEntities db = new KutuphaneDbEntities();
        public ActionResult Index()
        {
            var degerler = db.TBLYAZARs.ToList();
            return View(degerler);
           
        }
    }
}