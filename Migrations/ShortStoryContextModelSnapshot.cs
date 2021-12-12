﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TermProject.Data;

namespace TermProject.Migrations
{
    [DbContext(typeof(ShortStoryContext))]
    partial class ShortStoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TermProject.Models.Comment", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnName("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(1024)")
                        .HasMaxLength(1024);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Dislikes")
                        .HasColumnType("int");

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.Property<string>("ShortStoryID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("ShortStoryID");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            ID = "A",
                            Content = "Comment on short story #1",
                            CreatedAt = new DateTime(2021, 10, 31, 20, 46, 6, 846, DateTimeKind.Local).AddTicks(9336),
                            Dislikes = 0,
                            Likes = 0,
                            ShortStoryID = "A"
                        },
                        new
                        {
                            ID = "B",
                            Content = "Comment on short story #2",
                            CreatedAt = new DateTime(2021, 10, 31, 20, 46, 6, 847, DateTimeKind.Local).AddTicks(547),
                            Dislikes = 0,
                            Likes = 0,
                            ShortStoryID = "B"
                        },
                        new
                        {
                            ID = "C",
                            Content = "Comment on short story #3",
                            CreatedAt = new DateTime(2021, 10, 31, 20, 46, 6, 847, DateTimeKind.Local).AddTicks(597),
                            Dislikes = 0,
                            Likes = 0,
                            ShortStoryID = "C"
                        },
                        new
                        {
                            ID = "D",
                            Content = "Comment on short story #4",
                            CreatedAt = new DateTime(2021, 10, 31, 20, 46, 6, 847, DateTimeKind.Local).AddTicks(602),
                            Dislikes = 0,
                            Likes = 0,
                            ShortStoryID = "D"
                        });
                });

            modelBuilder.Entity("TermProject.Models.ShortStory", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnName("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(1024)")
                        .HasMaxLength(1024);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Dislikes")
                        .HasColumnType("int");

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("ShortStories");

                    b.HasData(
                        new
                        {
                            ID = "A",
                            Content = "Short story #1",
                            CreatedAt = new DateTime(2021, 10, 31, 20, 46, 6, 844, DateTimeKind.Local).AddTicks(1978),
                            Dislikes = 0,
                            Likes = 0
                        },
                        new
                        {
                            ID = "B",
                            Content = "Short story #2",
                            CreatedAt = new DateTime(2021, 10, 31, 20, 46, 6, 846, DateTimeKind.Local).AddTicks(8590),
                            Dislikes = 0,
                            Likes = 0
                        },
                        new
                        {
                            ID = "C",
                            Content = "Short story #3",
                            CreatedAt = new DateTime(2021, 10, 31, 20, 46, 6, 846, DateTimeKind.Local).AddTicks(8648),
                            Dislikes = 0,
                            Likes = 0
                        },
                        new
                        {
                            ID = "D",
                            Content = "Short story #4",
                            CreatedAt = new DateTime(2021, 10, 31, 20, 46, 6, 846, DateTimeKind.Local).AddTicks(8653),
                            Dislikes = 0,
                            Likes = 0
                        });
                });

            modelBuilder.Entity("TermProject.Models.Comment", b =>
                {
                    b.HasOne("TermProject.Models.ShortStory", null)
                        .WithMany("Comments")
                        .HasForeignKey("ShortStoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
