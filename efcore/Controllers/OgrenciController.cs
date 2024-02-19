using efcore.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace efcore.Controllers
{
    public class OgrenciController : Controller{

        private readonly DataContext _context;

        public OgrenciController (DataContext context){
            _context = context;
        }

        public async Task<IActionResult> Index(){
            return View(await _context.Ogrenciler.ToListAsync());
        }

        public IActionResult Create(){ //bu aslında bir get işlemidir.
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Ogrenci model){
            
            _context.Ogrenciler.Add(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");

        }

        public async Task<IActionResult> Edit(int? id){

            if(id == null)
            {
                return NotFound();
            }

            //var ogr = await _context.Ogrenciler.FindAsync(id);
            var ogr = await _context.Ogrenciler.FirstOrDefaultAsync(b => b.OgrenciId == id); //öncekine göre daha garanti bir yöntemdir.
            if(ogr == null)
            {
                return NotFound();
            }


            return View(ogr);
                

        }


    }
    
}