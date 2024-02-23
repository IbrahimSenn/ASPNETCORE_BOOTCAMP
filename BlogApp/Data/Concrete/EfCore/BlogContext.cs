using Microsoft.EntityFrameworkCore;
using BlogApp.Entity;

namespace BlogApp.Data.Concrete.EfCore
{
    public class BlogContext : DbContext //DB olması için bunu yaptık
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options) //SQL bağlantısı için bunu yapmamız gerekiyordu şimdi connection stringi yazmamız gereken bir alan oluşturduk.
        {

        }


        public DbSet<Post> Posts => Set<Post>();
        public DbSet<Comment> Comments => Set<Comment>();
        public DbSet<Tag> Tags => Set<Tag>();
        public DbSet<User> Users => Set<User>(); 

    }

    }