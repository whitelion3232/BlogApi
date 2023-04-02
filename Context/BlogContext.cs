using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApplication5.Models;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace WebApplication5.Context
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }

    }
}
