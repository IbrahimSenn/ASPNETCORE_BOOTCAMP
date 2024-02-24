namespace BlogApp.Entity
{
    public class Post{
        public int PostId { get; set; }
        public string? Title { get; set; }
        public string? Image {get;set;}
        public string? Content { get; set; }
        public DateTime PuslishedOn { get; set; } 
        public bool IsActive { get; set; } 
        public int UserId { get; set; } 
        public User User {get;set;} = null!; //Kullanıcı tablosu ile bağlantısını kurmak için entity'de nesne olarak tanımlamak gerekli. 
        //Bir post'u sadece bir user atabileceğinden tekil nesne oluşturduk.
        public List<Tag> Tags = new List<Tag>(); //bir postta birden fazla tag olabileceğinden tagleri List olarak çekeriz.
        public List<Comment> Comments = new List<Comment>();
        
    } 
}