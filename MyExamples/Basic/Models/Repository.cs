using Basix.Models;

namespace Basic.Models
{
    
    public class Repository{
        private static readonly List<Bootcamp> _Bootcamp = new List<Bootcamp>();
        static Repository(){
            _Bootcamp = new List<Bootcamp>{

                new Bootcamp(){ Id=1, Name="Gündem", Description="23 Şubatta kaza oranı değişti.", Image ="asya-borsa.jpg", IsActive= true },
                new Bootcamp(){ Id=2, Name="Sağlık", Description="Doktorlar bir hastalık tespit etti.",Image ="merso.png", IsActive= true },
                new Bootcamp(){ Id=3, Name="Bilim", Description="Nasa'dan yeni hamleler.. ",Image ="petrol.jpg", IsActive= true },
                
                new Bootcamp(){ Id=4, Name="Sağlık", Description="Doktorlar bir hastalık tespit etti.",Image ="merso.png", IsActive= false },
                new Bootcamp(){ Id=5, Name="Bilim", Description="Nasa'dan yeni hamleler.. ",Image ="petrol.jpg" ,IsActive= false},
                new Bootcamp(){ Id=6, Name="Gündem", Description="23 Şubatta kaza oranı değişti.", Image ="asya-borsa.jpg" ,IsActive= false },
                
                new Bootcamp(){ Id=7, Name="Sağlık", Description="Doktorlar bir hastalık tespit etti.",Image ="merso.png" ,IsActive= false},
                new Bootcamp(){ Id=8, Name="Gündem", Description="23 Şubatta kaza oranı değişti.", Image ="asya-borsa.jpg" ,IsActive= false },
                new Bootcamp(){ Id=9, Name="Bilim", Description="Nasa'dan yeni hamleler.. ",Image ="petrol.jpg" ,IsActive= false},

                };
            }
            public static List<Bootcamp> Bootcamps{
            get{
                return _Bootcamp;
            }
        }

        public static Bootcamp? GetById(int? id){

           return  _Bootcamp.FirstOrDefault(b =>b.Id == id);

           

        }
    }

}

