using System.ComponentModel.DataAnnotations;

namespace EntityFramework.Data
{
    public class KursKayit{
        [Key]
        public int KursKayitId {get;set;}
        public int OgrenciId {get;set;}
        public int KursId {get;set;}
        public DateTime KayitTarihi {get;set;}


    }
}