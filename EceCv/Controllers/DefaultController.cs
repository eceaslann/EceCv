﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EceCv.Models.Entity;

namespace EceCv.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbCvEntities2 db= new DbCvEntities2();
        public ActionResult Index()
        {
            var degerler = db.TblHakkimda.ToList();
            return View(degerler);
        }
        public PartialViewResult Deneyim()
        {
            var deneyimler = db.TblDeneyimlerim.ToList();
            return PartialView(deneyimler);
        }
        public PartialViewResult Egitimlerim()
        {
            var egitimler = db.TblEgitimlerim.ToList();
            return PartialView(egitimler);
        }
        public PartialViewResult Yeteneklerim()
        {
            var yetenekler = db.TblYeteneklerim.ToList();
            return PartialView(yetenekler);
        }
        public PartialViewResult Hobilerim()
        {
            var hobiler = db.TblHobilerim.ToList();
            return PartialView(hobiler);
        }
        public PartialViewResult Sertifikalarım()
        {
            var sertifikalar = db.TblSertifikalarım.ToList();
            return PartialView(sertifikalar);
        }
        [HttpGet]
        public PartialViewResult iletisim() { return PartialView(); }

        [HttpPost]
        public PartialViewResult iletisim(Tbliletisim t)
        { 
            t.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.Tbliletisim.Add(t);
            db.SaveChanges();
            return PartialView();
        }



    }
}