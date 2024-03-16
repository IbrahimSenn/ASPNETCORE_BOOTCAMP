using System.ComponentModel.DataAnnotations;

namespace LearningEfCore.Data
{
    public class Ogretmen{
        [Key]

        public int OgretmenId {get; set;}
        public string? OgretmenAd {get; set;}
        public string? OgretmenSoyad {get; set;}
        public string? Eposta {get; set;}
        public int? Telefon {get; set;}

        [DataType(DataType.Date)] //genel olarak kullanılan tarih modülasyonu budur.
            [DisplayFormat(DataFormatString ="{0:yyyy:MM:dd}", ApplyFormatInEditMode = true)]

        public DateTime BaslamaTarihi {get; set;}
        public ICollection<Kurs> Kurslar {get; set;} = new List<Kurs>();
    }
}