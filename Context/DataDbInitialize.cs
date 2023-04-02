using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.SqlServer;



namespace WebApplication5.Context
{
    public class DataDbInitialize
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<BlogContext>();
            context.Database.EnsureCreated();
        }
    }
}
