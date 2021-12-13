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
        public DbSet<ShortStoryReaction> ShortStoryReactions { get; set; }
        public DbSet<CommentReaction> CommentReactions { get; set; }

        public ShortStoryContext(DbContextOptions<ShortStoryContext> options) : base(options) {}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var stories = new List<ShortStory>
            {
                new ShortStory { Title="Short story #1", Author="System", Content="Content for short story #1"},
                new ShortStory { Title = "Short story #2", Author="System", Content="Content for short story #2" },
                new ShortStory { Title = "Short story #3", Author="System", Content="Content for short story #3" },
                new ShortStory { Title = "Short story #4", Author="System", Content="Content for short story #4" }
            };

            var comments = new List<Comment>
            {
                new Comment { ShortStoryID = stories[0].ID, Author="System", Content = "Comment on short story #1" },
                new Comment { ShortStoryID = stories[1].ID, Author="System", Content = "Comment on short story #2" },
                new Comment { ShortStoryID = stories[2].ID, Author="System", Content = "Comment on short story #3" },
                new Comment { ShortStoryID = stories[3].ID, Author="System", Content = "Comment on short story #4" },
            };

            modelBuilder.Entity<ShortStory>().HasData(stories);
            modelBuilder.Entity<Comment>().HasData(comments);
            modelBuilder.Entity<ShortStoryReaction>();
            modelBuilder.Entity<CommentReaction>();
        }
    }
}
