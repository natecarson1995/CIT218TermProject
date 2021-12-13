﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TermProject.Data;

namespace TermProject.Migrations
{
    [DbContext(typeof(ShortStoryContext))]
    [Migration("20211213162255_AddedTitleSeedData")]
    partial class AddedTitleSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            ID = "453c6404-a603-44aa-a4de-426959806b0b",
                            Content = "Comment on short story #1",
                            CreatedAt = new DateTime(2021, 12, 13, 11, 22, 55, 173, DateTimeKind.Local).AddTicks(8125),
                            Dislikes = 0,
                            Likes = 0,
                            ShortStoryID = "fa2ffe69-3726-46d4-aebf-90d1a341b256"
                        },
                        new
                        {
                            ID = "2c63bf99-e1c1-4157-9078-e3b4623b1c51",
                            Content = "Comment on short story #2",
                            CreatedAt = new DateTime(2021, 12, 13, 11, 22, 55, 173, DateTimeKind.Local).AddTicks(8945),
                            Dislikes = 0,
                            Likes = 0,
                            ShortStoryID = "0b352754-2d76-4a18-99a3-dbb83d999b9a"
                        },
                        new
                        {
                            ID = "36a577c1-cc3b-4fa0-9e7d-209c9c1a3c36",
                            Content = "Comment on short story #3",
                            CreatedAt = new DateTime(2021, 12, 13, 11, 22, 55, 173, DateTimeKind.Local).AddTicks(8979),
                            Dislikes = 0,
                            Likes = 0,
                            ShortStoryID = "fc03d7b0-1109-453f-9e76-ebfa1fd475c4"
                        },
                        new
                        {
                            ID = "bcadf907-9112-47cf-8ad7-7e5e06c351dc",
                            Content = "Comment on short story #4",
                            CreatedAt = new DateTime(2021, 12, 13, 11, 22, 55, 173, DateTimeKind.Local).AddTicks(8985),
                            Dislikes = 0,
                            Likes = 0,
                            ShortStoryID = "35c3d70f-22f5-4811-a10c-497814335f8f"
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

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(24)")
                        .HasMaxLength(24);

                    b.HasKey("ID");

                    b.ToTable("ShortStories");

                    b.HasData(
                        new
                        {
                            ID = "fa2ffe69-3726-46d4-aebf-90d1a341b256",
                            Content = "Content for short story #1",
                            CreatedAt = new DateTime(2021, 12, 13, 11, 22, 55, 171, DateTimeKind.Local).AddTicks(2107),
                            Dislikes = 0,
                            Likes = 0,
                            Title = "Short story #1"
                        },
                        new
                        {
                            ID = "0b352754-2d76-4a18-99a3-dbb83d999b9a",
                            Content = "Content for short story #2",
                            CreatedAt = new DateTime(2021, 12, 13, 11, 22, 55, 173, DateTimeKind.Local).AddTicks(7116),
                            Dislikes = 0,
                            Likes = 0,
                            Title = "Short story #2"
                        },
                        new
                        {
                            ID = "fc03d7b0-1109-453f-9e76-ebfa1fd475c4",
                            Content = "Content for short story #3",
                            CreatedAt = new DateTime(2021, 12, 13, 11, 22, 55, 173, DateTimeKind.Local).AddTicks(7158),
                            Dislikes = 0,
                            Likes = 0,
                            Title = "Short story #3"
                        },
                        new
                        {
                            ID = "35c3d70f-22f5-4811-a10c-497814335f8f",
                            Content = "Content for short story #4",
                            CreatedAt = new DateTime(2021, 12, 13, 11, 22, 55, 173, DateTimeKind.Local).AddTicks(7165),
                            Dislikes = 0,
                            Likes = 0,
                            Title = "Short story #4"
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
