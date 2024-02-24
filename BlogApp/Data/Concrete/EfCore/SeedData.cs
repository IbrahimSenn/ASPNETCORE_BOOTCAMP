using BlogApp.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Data.Concrete.EfCore
{
    //Hazır verileri çekicez yani test verileri gibi.
    public static class SeedData    //Dışarıdan nesne oluşturmadan kullanabilmek için static.
    {
        public static void TestVerileriDoldur(IApplicationBuilder app)//Bu interface ile  builder'ın içine bu methodu dahil edebiliyoruz.
        {
            var context = app.ApplicationServices.CreateScope().ServiceProvider.GetService<BlogContext>();

            if (context != null)
            {
                if (context.Database.GetPendingMigrations().Any())
                {
                    context.Database.Migrate();
                }
                if (!context.Tags.Any())
                {
                    context.Tags.AddRange(
                        new Tag {Text = "Web Geliştirme"},
                        new Tag {Text = "Backend"},
                        new Tag {Text = "Frontend"},
                        new Tag {Text = "Full Stack"},
                        new Tag {Text = "Game"}
                    );
                    context.SaveChanges();
                }
                if (!context.Users.Any())
                {
                    context.Users.AddRange(
                        new User {UserName = "Espres Done"},
                        new User {UserName = "Star Kiss"}
                    );

                    context.SaveChanges();
                }

                 if (!context.Posts.Any())
                {
                    context.Posts.AddRange(
                        new Post {  Title  = "Asp.Net Core",
                                    Content = "Öğrencilere ücretsiz yazılım eğitimi",
                                    IsActive = true,
                                    PuslishedOn = DateTime.Now.AddDays(-7),
                                    Tags = context.Tags.Take(3).ToList(),
                                    UserId = 1 
                                    },
                        
                        new Post {  Title  = "Kariyer Günleri",
                                    Content = "Öğrenciler ile işverenlerin buluşması..",
                                    IsActive = true,
                                    PuslishedOn = DateTime.Now.AddDays(-10),
                                    Tags = context.Tags.Take(3).ToList(),
                                    UserId = 2
                                    }
                        
                    );

                    context.SaveChanges();
                }
            }

        }
    }
    
}