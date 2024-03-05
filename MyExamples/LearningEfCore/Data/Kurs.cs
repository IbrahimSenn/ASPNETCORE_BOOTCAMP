using System.ComponentModel.DataAnnotations;

namespace LearningEfCore.Data{
    public class Kurs{
        [Key]
        public int KursId {get;set;}
        public string? KursAdi {get;set;}

    }
}