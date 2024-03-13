using System.IO.Compression;
using System.Runtime.CompilerServices;
using LearningEfCore.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace LearningEfCore.Controllers
{
    public class OgrenciController : Controller{

        private readonly DataContext _context;
        public OgrenciController(DataContext context)
        {
           _context = context ;
        }

        public async Task<IActionResult> Index(){

            return View(await _context.Ogrenciler.ToListAsync());
        }
        public IActionResult Create(){

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Ogrenci model){

            _context.Ogrenciler.Add(model);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index"); //başka bir controller indexine gitmek istenirse ("Index","Home") şeklinde belirtilir.
        }
        
        
        public async Task<IActionResult> Edit(int? id){
            
            if (id == null)
            {
                return NotFound();
            }

            //var kisi = await _context.Ogrenciler.FindAsync(id);
            var kisi = await _context.Ogrenciler
            .Include(m => m.KursKayitlari)
            .ThenInclude(m =>m.Kurs)
            .FirstOrDefaultAsync(b => b.OgrenciId == id);   //bu daha garanti bir yöntemdir.

            if (kisi == null)
            {
                return NotFound();
            }

            return View(kisi);
         }
         [HttpPost]

         public async Task<IActionResult> Edit(int? id, Ogrenci Model){

            if (id != Model.OgrenciId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(Model);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException) //aynı hesabın şifresini eş zamanlı olarak iki farklı kişi değiştirmek isterse bu döngüyü yakalar  
                {

                    if (!_context.Ogrenciler.Any(o => o.OgrenciId == Model.OgrenciId))
                    {
                        return NotFound();
                    }
                     else
                     {
                        throw;
                     }
                }
                return RedirectToAction("Index");
            }
            return View(Model);
         }

          public async Task<IActionResult> Delete(int? id){
            
            if (id == null)
            {
                return NotFound();
            }

            //var kisi = await _context.Ogrenciler.FindAsync(id);
            var kisi = await _context.Ogrenciler.FindAsync(id); //bu daha garanti bir yöntemdir.

            if (kisi == null)
            {
                return NotFound();
            }

            return View(kisi);
         }

         [HttpPost]

         public async Task<IActionResult> Delete([FromForm] int id){

            var ogr = await _context.Ogrenciler.FindAsync(id);
            if ( ogr == null )
            {
                return NotFound();
            }
            
            _context.Ogrenciler.Remove(ogr);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");

         }


    
}
}