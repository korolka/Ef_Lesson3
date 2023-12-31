﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_Lesson3
{
    public class DatabaseContext:DbContext
    {
        public DbSet<Cart> Carts { get; set;}
        public DbSet<User> Users { get; set;}
        public DbSet<Product> Products { get; set;}
        public DbSet<Category> Categories { get; set;}
        public DbSet<KeyParams> KeyParams { get; set;}
        public DbSet<Word> Words { get; set;}
        public DatabaseContext() 
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=EfLesson3;Trusted_Connection=true;");
        }
    }

}
