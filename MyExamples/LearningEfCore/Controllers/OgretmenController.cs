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
        





    }
}