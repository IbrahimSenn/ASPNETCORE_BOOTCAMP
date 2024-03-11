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

        public async Task<IActionResult> Create(){

            ViewBag.Ogrenciler = new SelectList( await _context.Ogrenciler.ToListAsync(), "OgrenciId", "AdSoyad" ) ;
            ViewBag.Kurslar = new SelectList( await _context.Kurslar.ToListAsync(), "KursId", "KursAdi" ) ;

            return View();
        }








    }
}