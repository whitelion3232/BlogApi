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
        public virtual Article Article { get; set; }

        public string AuthorId { get; set; }
        public virtual User Author { get; set; }
    }
}
