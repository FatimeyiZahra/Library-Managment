using System;
using System.Collections.Generic;
using System.Text;
using Library_Managment.Models;
using Microsoft.EntityFrameworkCore;

namespace Library_Managment.Data
{
    public class LibraryContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-DGKGL9C\MSSQLSERVER01;Database=Library;Integrated Security=True");
        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Issue> Issues { get; set; }
        public DbSet<ReturnBook> ReturnBooks { get; set; }
        public DbSet<Basket> Baskets { get; set; }



    }
}