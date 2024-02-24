using BlogApp.Data.Abstract;
using BlogApp.Data.Concrete.EfCore;
using Microsoft.AspNetCore.Mvc;

namespace Blogapp.Controllers
{
    public class PostsController : Controller{

        private readonly IPostRepository _repository ; //Repository pattern yaptık. Veri tabanı arasındaki işlemleri soyutlamak ve uygulama katmanları arasındaki bağımlılığı azaltmak i.im kullanıyoruz.
        public PostsController(IPostRepository context){
            _repository = context;
        }
        public IActionResult Index(){
            return View(_repository.Posts.ToList());
        }
    }
}