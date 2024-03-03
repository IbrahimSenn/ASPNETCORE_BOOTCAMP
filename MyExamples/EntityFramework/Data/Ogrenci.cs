using System.ComponentModel.DataAnnotations;

namespace EntityFramework.Data
{
    public class Ogrenci{
        [Key]

        public int OgrernciId {get;set;}
        public string? OgrenciAd {get;set;}
        public string? OgrenciSoyad {get;set;}
        public string? Eposta {get;set;}
        public int? Gsm {get;set;}

    }
}