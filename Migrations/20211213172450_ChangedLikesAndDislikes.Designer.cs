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
    [Migration("20211213172450_ChangedLikesAndDislikes")]
    partial class ChangedLikesAndDislikes
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

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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
                            ID = "3ff26bad-4379-4890-a805-a92fc1b06aa1",
                            Author = "System",
                            Content = "Comment on short story #1",
                            CreatedAt = new DateTime(2021, 12, 13, 12, 24, 49, 954, DateTimeKind.Local).AddTicks(6084),
                            Dislikes = 0,
                            Likes = 0,
                            ShortStoryID = "f8e55433-64b4-4d8f-99b7-a5191797d4ab"
                        },
                        new
                        {
                            ID = "c02176ba-8851-48c3-8b16-a37457a7a188",
                            Author = "System",
                            Content = "Comment on short story #2",
                            CreatedAt = new DateTime(2021, 12, 13, 12, 24, 49, 954, DateTimeKind.Local).AddTicks(7099),
                            Dislikes = 0,
                            Likes = 0,
                            ShortStoryID = "d9d5fd7f-f1f2-41c8-8ead-05d999e2a2d5"
                        },
                        new
                        {
                            ID = "f317f9c3-aba4-4f81-a1f1-d5c12c7e2735",
                            Author = "System",
                            Content = "Comment on short story #3",
                            CreatedAt = new DateTime(2021, 12, 13, 12, 24, 49, 954, DateTimeKind.Local).AddTicks(7143),
                            Dislikes = 0,
                            Likes = 0,
                            ShortStoryID = "5d54ae46-6b33-4eb2-8cab-01e5201a31f9"
                        },
                        new
                        {
                            ID = "70ac696b-961a-401e-9a74-0ac5d9fd8753",
                            Author = "System",
                            Content = "Comment on short story #4",
                            CreatedAt = new DateTime(2021, 12, 13, 12, 24, 49, 954, DateTimeKind.Local).AddTicks(7149),
                            Dislikes = 0,
                            Likes = 0,
                            ShortStoryID = "488f2e68-0c69-48e0-8e66-69dc2bc1995b"
                        });
                });

            modelBuilder.Entity("TermProject.Models.ShortStory", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnName("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(1024)")
                        .HasMaxLength(1024);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(24)")
                        .HasMaxLength(24);

                    b.HasKey("ID");

                    b.ToTable("ShortStories");

                    b.HasData(
                        new
                        {
                            ID = "f8e55433-64b4-4d8f-99b7-a5191797d4ab",
                            Author = "System",
                            Content = "Content for short story #1",
                            CreatedAt = new DateTime(2021, 12, 13, 12, 24, 49, 951, DateTimeKind.Local).AddTicks(9076),
                            Title = "Short story #1"
                        },
                        new
                        {
                            ID = "d9d5fd7f-f1f2-41c8-8ead-05d999e2a2d5",
                            Author = "System",
                            Content = "Content for short story #2",
                            CreatedAt = new DateTime(2021, 12, 13, 12, 24, 49, 954, DateTimeKind.Local).AddTicks(5122),
                            Title = "Short story #2"
                        },
                        new
                        {
                            ID = "5d54ae46-6b33-4eb2-8cab-01e5201a31f9",
                            Author = "System",
                            Content = "Content for short story #3",
                            CreatedAt = new DateTime(2021, 12, 13, 12, 24, 49, 954, DateTimeKind.Local).AddTicks(5170),
                            Title = "Short story #3"
                        },
                        new
                        {
                            ID = "488f2e68-0c69-48e0-8e66-69dc2bc1995b",
                            Author = "System",
                            Content = "Content for short story #4",
                            CreatedAt = new DateTime(2021, 12, 13, 12, 24, 49, 954, DateTimeKind.Local).AddTicks(5177),
                            Title = "Short story #4"
                        });
                });

            modelBuilder.Entity("TermProject.Models.ShortStoryReaction", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnName("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Reaction")
                        .HasColumnType("int");

                    b.Property<string>("ShortStoryID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("ShortStoryID");

                    b.ToTable("ShortStoryReaction");
                });

            modelBuilder.Entity("TermProject.Models.Comment", b =>
                {
                    b.HasOne("TermProject.Models.ShortStory", null)
                        .WithMany("Comments")
                        .HasForeignKey("ShortStoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TermProject.Models.ShortStoryReaction", b =>
                {
                    b.HasOne("TermProject.Models.ShortStory", "ShortStory")
                        .WithMany("Reactions")
                        .HasForeignKey("ShortStoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}