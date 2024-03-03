

using Basic.Models;
using Basix.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basix.Controllers
{
    public class BootcampController : Controller
    {
        public IActionResult Index(int? id){

            if (id == null)
            {
                return RedirectToAction("List",  "bootcamp"  ) ;
            }

            var haber = Repository.GetById(id);
            return View(haber);
        }
        public IActionResult List(){
            
            return View(Repository.Bootcamps) ;
        }
        
    }
}