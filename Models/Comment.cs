using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace WebApplication5.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime DatePosted { get; set; }

        public int ArticleId { get; set; }
         public Article Article { get; set; } // Navigation property

        public int AuthorId { get; set; }
        public User Author { get; set; } // Navigation property

        // Other properties...
    }
}
