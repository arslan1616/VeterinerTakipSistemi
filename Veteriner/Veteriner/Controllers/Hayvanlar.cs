using Microsoft.AspNetCore.Mvc;
using Veteriner.DataBase;

namespace Veteriner.Controllers
{
    public class Hayvanlar : Controller
    {
        ApplicationConnectionDb db = new ApplicationConnectionDb();
        public IActionResult Yeni()
        {
            ViewBag.Baslik = "Hayvanlar Ekle";
            return View();
        }

        public IActionResult Listele()
        {
            ViewBag.Baslik = "Hayvanları Listele";
            return View();
        }

        [HttpPost]
        public ActionResult YeniHayvanKayit(Hayvan YHB)
        {
            YHB.KayitTarihi = DateTime.Now;
            db.Hayvan.Add(YHB);
            db.SaveChanges();
            return RedirectToAction("Listele");
        }

        [HttpPost]
        public ActionResult HayvanDuzenle(Hayvan YGHB)
        {
            Hayvan EOHB = db.Hayvan.FirstOrDefault(x => x.id == YGHB.id);
            EOHB.KategoriId = YGHB.KategoriId;
            EOHB.Adi = YGHB.Adi;
            EOHB.NotBilgisi = YGHB.NotBilgisi;
            EOHB.Cinsi = YGHB.Cinsi;
            EOHB.DogumTarihi = YGHB.DogumTarihi;
            EOHB.KisiId = YGHB.KisiId;
            EOHB.KimlikNo = YGHB.KimlikNo;
            db.SaveChanges();
            return RedirectToAction("Listele");
        }

        [HttpPost]
        public ActionResult HayvanSil(Hayvan YGHB)
        {
            Hayvan EOHB = db.Hayvan.FirstOrDefault(x => x.id == YGHB.id);
            db.Hayvan.Remove(EOHB);
            db.SaveChanges();
            return RedirectToAction("Listele");
        }

    }
}