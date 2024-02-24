using BlogApp.Entity;

namespace BlogApp.Data.Abstract
{
    public interface IPostRepository{ //repository'nin arayüzünü oluşturduk.
        IQueryable<Post> Posts {get;} //post sınıfının veri tabanındaki tüm verileri çekmek almak için bu interface kullanıldı.

        void CreatePost(Post post);
    }
}