using System.ComponentModel.DataAnnotations;

namespace efcore.Data{
    public class KursKayit{
        [Key]
        public int KayitId{get; set;}
        public int OgrenciId{get; set;}
        public Ogrenci Ogrenci {get;set;} = null!;    // Tablo ilişkileri için bir nesne oluşturduk. 
        public int KursId{get; set;}
        public Kurs Kurs {get;set;} = null!;   // Tablo ilişkileri için bir nesne oluşturduk. 
        public DateTime KayitTarihi{get; set;}
    }
}