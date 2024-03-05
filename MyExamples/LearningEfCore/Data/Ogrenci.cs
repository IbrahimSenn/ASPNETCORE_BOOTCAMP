using System.ComponentModel.DataAnnotations;

namespace LearningEfCore.Data
{
    public class Ogrenci{
        [Key]

        public int OgrenciId { get; set; }
        public string? OgrenciAd { get; set; }
        public string? OgrenciSoyad { get; set; }
        public string? Eposta { get; set; }
        public int? Telefon { get; set; }
    }
}