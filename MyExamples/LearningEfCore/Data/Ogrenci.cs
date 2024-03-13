using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace LearningEfCore.Data
{
    public class Ogrenci{
        [Key]

        public int OgrenciId { get; set; }
        public string? OgrenciAd { get; set; }
        public string? OgrenciSoyad { get; set; }

        public string AdSoyad {get{
            return this.OgrenciAd + " " + this.OgrenciSoyad ;
        }
        }
        public string? Eposta { get; set; }
        public int? Telefon { get; set; }

        public ICollection<KursKayit> KursKayitlari {get; set;} = new List<KursKayit>(); // Burada gözümden kaçan get-set bloğu hatasını bulmak saatlerimi aldı!!


        
                }
}