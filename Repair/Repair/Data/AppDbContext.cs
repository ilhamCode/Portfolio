using Microsoft.EntityFrameworkCore;
using Repair.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repair.Data
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryToBlog>()
         .HasKey(cb => new { cb.CategoryId, cb.BlogId });

            modelBuilder.Entity<CategoryToBlog>()
        .HasOne(cb => cb.Category)
        .WithMany(c => c.CategoryToBlogs)
        .HasForeignKey(cb => cb.CategoryId);

            modelBuilder.Entity<CategoryToBlog>()
        .HasOne(bc => bc.Blog)
        .WithMany(b => b.CategoryToBlogs)
        .HasForeignKey(bc => bc.BlogId);


        }

        public DbSet<Servie>Blogs { get; set; }
        public DbSet<Category>Categories { get; set; }
        public DbSet<CategoryToBlog> CategoryToBlogs { get; set; }

        public DbSet<Comment>Comments { get; set; }
        public DbSet<FeedBack>FeedBacks { get; set; }
        public DbSet<Position>Positions { get; set; }
        public DbSet<Reply>Replies { get; set; }
        public DbSet<Service>Services { get; set; }
        public DbSet<Setting>Settings { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
