using LearningEfCore.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace LearningEfCore.Controllers
{
    public class KursKayitController : Controller{

        private readonly DataContext _context;

        public KursKayitController (DataContext context ){
            _context = context;
        }

        public async Task<IActionResult> Index(){ //burada listeleme işlemi yapacağımız için ilişkilendidiğimiz tabloların özelliklerini dahil etmemiz gerekiyor.

        var kursKayit = await _context.Kayitlar
        .Include( x => x.Kurs)
        .Include(x => x.Ogrenci)
        .ToListAsync();


            return View(kursKayit);
        }

        public async Task<IActionResult> Create(){

            ViewBag.Ogrenciler = new SelectList( await _context.Ogrenciler.ToListAsync(), "OgrenciId", "AdSoyad" ) ;
            ViewBag.Kurslar = new SelectList( await _context.Kurslar.ToListAsync(), "KursId", "KursAdi" ) ;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(KursKayit model){

            model.KayitTarihi = DateTime.Now;
            _context.Kayitlar.Add(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }


    }
}