namespace Basics.Models
{
    public class Repository
    {
        private static readonly List<Bootcamp> _bootcamp = new();

        static Repository()
        {
            _bootcamp = new List<Bootcamp>()
            {
            new Bootcamp(){Id=1, Title="Asp Net Core Eğitimi", Description="23 Ocak'da başlıyor...",Image="1.jpg", Tags = new string[]{"AspNetCore", "Web Geliştirme"}, isActive = false, isHome = true},
            new Bootcamp(){Id=2, Title="SQL Eğitimi", Description="27 Ocak'da başlıyor..", Image="2.jpg", Tags = new string[]{"Data", "Veri"}, isActive = true, isHome = true},
            new Bootcamp(){Id=3, Title="Oracle Eğitimi", Description="2 Şubat'da başlıyor..", Image ="3.jpg", Tags = new string[]{"Unity", "Game"}, isActive = true, isHome = false},
            new Bootcamp(){Id=4, Title="Full Stack Eğitimi", Description="6 Şubat'da başlıyor..", Image ="4.jpg", Tags = new string[]{"Frontend", "Backend"}, isActive = true, isHome = true}
            };
        }
        public static List<Bootcamp> Bootcamps{
            get{
                return _bootcamp;
            }
        }

        public static Bootcamp? GetById(int? id)
        {
            return _bootcamp.FirstOrDefault(b => b.Id == id );
        }


    }


}