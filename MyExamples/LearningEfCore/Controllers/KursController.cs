using LearningEfCore.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LearningEfCore.Controllers
{
    public class KursController : Controller{

        private readonly DataContext _context;
        public KursController(DataContext context){
            _context = context;
        }

          public async Task<IActionResult> Index(){

            return View(await _context.Kurslar.ToListAsync());
        }


        public IActionResult Create(){
            //bu get işlemi yapan method
            return View();
        }
       

         [HttpPost]
        public async Task<IActionResult> Create(Kurs model){

            _context.Kurslar.Add(model);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index"); //başka bir controller indexine gitmek istenirse ("Index","Home") şeklinde belirtilir.
        }


                 public async Task<IActionResult> Edit(int? id){
            
            if (id == null)
            {
                return NotFound();
            }

            //var kisi = await _context.Ogrenciler.FindAsync(id);
            var ders = await _context.Kurslar
            .Include(m=>m.KursKayitlari)
            .ThenInclude(m=>m.Ogrenci)
            .FirstOrDefaultAsync(b =>b.KursId == id); //bu daha garanti bir yöntemdir.

            if (ders == null)
            {
                return NotFound();
            }

            return View(ders);
                 }



            [HttpPost]

            public async Task<IActionResult> Edit(int? id, Kurs Model){

            if (id != Model.KursId)
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

                    if (!_context.Kurslar.Any(o => o.KursId == Model.KursId))
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

                if ( id == null )
                {
                    return NotFound();
                }

                var krs = await _context.Kurslar.FindAsync(id);

                if ( krs == null )
                {
                    return NotFound();
                    
                }

                return View(krs);


            }

            [HttpPost]

            public async Task<IActionResult> Delete([FromForm] int id) {

                var del = await _context.Kurslar.FindAsync(id);
                if ( del==null )
                {
                    return NotFound();
                }

                _context.Kurslar.Remove(del);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");


            }


    }
    
}