using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers{

    public class BootcampController : Controller {

         public IActionResult Details(int? id){

            if (id == null)
            {
                return RedirectToAction("List","Bootcamp");
            }

            var kurs = Repository.GetById(id);
             return View(kurs);
         }

    public IActionResult List(){

       
       return View(Repository.Bootcamps);
    }
    }
}