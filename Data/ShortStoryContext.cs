using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TermProject.Models;

namespace TermProject.Data
{
    public class ShortStoryContext : DbContext
    {
        public DbSet<ShortStory> ShortStories { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public ShortStoryContext(DbContextOptions<ShortStoryContext> options) : base(options) {}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var stories = new List<ShortStory>
            {
                new ShortStory { ID = "A", Likes=0, Dislikes=0, Content="Short story #1"},
                new ShortStory { ID = "B", Likes = 0, Dislikes = 0, Content = "Short story #2" },
                new ShortStory { ID = "C", Likes = 0, Dislikes = 0, Content = "Short story #3" },
                new ShortStory { ID = "D", Likes = 0, Dislikes = 0, Content = "Short story #4" }
            };

            var comments = new List<Comment>
            {
                new Comment { ID = "A", ShortStoryID = "A", Likes = 0, Dislikes = 0, Content = "Comment on short story #1" },
                new Comment { ID = "B", ShortStoryID = "B", Likes = 0, Dislikes = 0, Content = "Comment on short story #2" },
                new Comment { ID = "C", ShortStoryID = "C", Likes = 0, Dislikes = 0, Content = "Comment on short story #3" },
                new Comment { ID = "D", ShortStoryID = "D", Likes = 0, Dislikes = 0, Content = "Comment on short story #4" }
            };

            modelBuilder.Entity<ShortStory>().HasData(stories);
            modelBuilder.Entity<Comment>().HasData(comments);
        }
    }
}
