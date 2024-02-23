namespace BlogApp.Entity
{
    public class User{
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public List<Post> Posts { get; set; } = new List<Post>(); //bir kullanıcı birden fazla post atabileceği için List<> olarak çekiyoruz.
        public List<Comment> Comments {get;set;} = new List<Comment>();
    }
}