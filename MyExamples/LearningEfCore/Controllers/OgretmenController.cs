using LearningEfCore.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LearningEfCore.Controllers
{
    public class OgretmenController : Controller{

        private readonly DataContext _context ;

        public OgretmenController (DataContext context){
            _context = context;
        }

        public async Task<IActionResult> Index(){

            var page = await _context.Ogretmenler.ToListAsync();

            return View(page);
        }
        public IActionResult Create(){

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Ogretmen model){

            _context.Ogretmenler.Add(model);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index"); //başka bir controller indexine gitmek istenirse ("Index","Home") şeklinde belirtilir.
        }
        


        public async Task<IActionResult> Edit(int? id){
            
            if (id == null)
            {
                return NotFound();
            }

            //var kisi = await _context.Ogrenciler.FindAsync(id);
            var ogr = await _context.Ogretmenler.FirstOrDefaultAsync(b => b.OgretmenId == id);   //bu daha garanti bir yöntemdir.

            if (ogr == null)
            {
                return NotFound();
            }

            return View(ogr);
         }

         [HttpPost]

         public async Task<IActionResult> Edit(int? id, Ogretmen Model){

            if (id != Model.OgretmenId)
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

                    if (!_context.Ogretmenler.Any(o => o.OgretmenId == Model.OgretmenId))
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

            if(id == null){

                return NotFound();
            }

            var kisi = await _context.Ogretmenler.FindAsync(id);

            if(kisi == null){

                return NotFound();
            }

            return View(kisi);

         }

         [HttpPost]

         public async Task<IActionResult> Delete([FromForm] int id ){


            var del = await _context.Ogretmenler.FindAsync(id);

            if (del == null)
            {
                return NotFound();
            }

            _context.Ogretmenler.Remove(del);

            await _context.SaveChangesAsync();
            return RedirectToAction ("Index");


         }







    }
}