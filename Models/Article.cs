namespace WebApplication5.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }

        public int AuthorId { get; set; }
         public User Author { get; set; } // Navigation property

        // Other properties...
    }

}
