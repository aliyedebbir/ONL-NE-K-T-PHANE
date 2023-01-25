using System;
using System.Collections.Generic;
using System.Text;
using Library.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Library.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        
        public DbSet<Category> Categories { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Buy> Buys { get; set; }

        public DbSet<Language> Languages { get; set; }

        public DbSet<Publisher> Publishers { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
    }
}
