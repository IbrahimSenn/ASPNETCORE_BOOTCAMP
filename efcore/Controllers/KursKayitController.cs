using efcore.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace efcore.Controllers
{
    public class KursKayitController : Controller{
        private readonly DataContext _context;

        public KursKayitController(DataContext context){
            _context = context;
        }

        public IActionResult Index(){

            var kursKayitlari = _context.KursKayitlari.ToListAsync();

            return View(kursKayitlari);

        }

        public async Task<IActionResult> Create(){

            ViewBag.Ogrenciler = new SelectList(await _context.Ogrenciler.ToListAsync(), "OgrenciId", "AdSoyad"  ); 
            ViewBag.Kurslar = new SelectList(await _context.Kurslar.ToListAsync(), "KursId", "Baslik"  );

            return View();
        }
        //Post işlemi yapabilemiz için bir model dönmemiz gerekiyor.

        [HttpPost]
        public async Task<IActionResult> Create(KursKayit model ){


            _context.KursKayitlari.Add(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}   