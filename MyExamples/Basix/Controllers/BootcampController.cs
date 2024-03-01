

using Basix.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basix.Controllers
{
    public class BootcampController : Controller
    {
        public IActionResult Index(){

            var kurs = new Bootcamp();
            kurs.Id = 1;
            kurs.Name = "Asp.NetCore";
            kurs.Description = "23 Ocak'da başlıyor";

            return View(kurs);
        }
        public IActionResult List(){

            var kurslar = new List<Bootcamp>(){
                new Bootcamp(){ Id=1, Name="Gündem", Description="23 Şubatta kaza oranı değişti.", Image ="asya-borsa.jpg" },
                new Bootcamp(){ Id=2, Name="Sağlık", Description="Doktorlar yeni bir hastalık tespit etti.",Image ="merso.png" },
                new Bootcamp(){ Id=3, Name="Bilim", Description="Nasa'dan yeni hamleler.. ",Image ="petrol.jpg" },
            };

            return View(kurslar) ;
        }
        
    }
}