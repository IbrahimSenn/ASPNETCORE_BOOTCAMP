using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers{

    public class BootcampController : Controller {

        public IActionResult Index(){

            var kurs = new Bootcamp();

            kurs.Id = 1;
            kurs.Title = "Asp Net Core Bootcamp";
            kurs.Description = "23 Ocak'da başlıyor..'";
            kurs.Image = "1.jpg";

            return View(kurs);
        }

    public IActionResult List(){

       var kurslar = new List<Bootcamp>(){
           new Bootcamp(){Id=1, Title="Asp Net Core Eğitimi", Description="23 Ocak'da başlıyor..",Image="1.jpg"},
           new Bootcamp(){Id=2, Title="SQL Eğitimi", Description="27 Ocak'da başlıyor..", Image="2.jpg"},
           new Bootcamp(){Id=3, Title="Oracle Eğitimi", Description="2 Şubat'da başlıyor..", Image ="3.jpg"},
           new Bootcamp(){Id=4, Title="Full Stack Eğitimi", Description="6 Şubat'da başlıyor..", Image ="3.jpg"}
      
           };
       return View(kurslar);
    }
    }
}