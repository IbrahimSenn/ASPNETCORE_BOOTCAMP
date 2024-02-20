using efcore.Data;
using Microsoft.AspNetCore.Mvc;

namespace efcore.Controllers //Önce controller ve sonra view oluşturulur.  
{
    public class KursController : Controller{
        
        private readonly DataContext _context;

        public KursController (DataContext context){
            _context = context;
        }


        public IActionResult Create(){ //bu aslında bir get işlemidir.
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Kurs model){
            
            _context.Kurslar.Add(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");

        }


    }
}