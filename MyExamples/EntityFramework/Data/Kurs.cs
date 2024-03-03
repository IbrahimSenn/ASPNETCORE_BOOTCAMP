using System.ComponentModel.DataAnnotations;

namespace EntityFramework.Data
{
    public class Kurs{
        [Key]
        public int KursId {get;set;}
        public string? Baslik {get;set;}
    }
}