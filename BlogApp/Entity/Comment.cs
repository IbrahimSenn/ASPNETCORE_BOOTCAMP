namespace BlogApp.Entity
{
    public class Comment{
        public int CommentId {get;set;}
        public string? Text {get;set;}
        public DateTime PublishedOn {get;set;}
        public int PostId {get;set;}
        public Post Post = null!; //tabloda bunu kullanabilmek için önce PosdtId çekilmelidir.
        public int UserId {get;set;}
        public User User = null!;
    }
}