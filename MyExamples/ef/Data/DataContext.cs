using Microsoft.EntityFrameworkCore;

namespace ef.Data
{
    public class DataContext : DbContext{
        public DataContext(DbContextOptions<DataContext> options) : base(options){
            
        }
        public DbSet<Kurs> Kurslar => Set<Kurs>();
       
        public DbSet<Ogrenci> Ogrenciler => Set<Ogrenci>(); 
        public DbSet<KursKayit> Kayitlar => Set<KursKayit>();
    }
}