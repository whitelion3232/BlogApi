namespace WebApplication5.Models
{
    
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Comment> Comments { get; set; } // добавлено свойство Comments

        // Other properties...
    }
}
