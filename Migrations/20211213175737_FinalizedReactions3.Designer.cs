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
    [Migration("20211213175737_FinalizedReactions3")]
    partial class FinalizedReactions3
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

                    b.Property<string>("ShortStoryID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("ShortStoryID");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            ID = "d3074dc1-7d88-42e2-915d-9ae567a4d2ed",
                            Author = "System",
                            Content = "Comment on short story #1",
                            CreatedAt = new DateTime(2021, 12, 13, 12, 57, 37, 79, DateTimeKind.Local).AddTicks(6417),
                            ShortStoryID = "0042ae2a-a45f-47cd-84d8-b862d38ba5e9"
                        },
                        new
                        {
                            ID = "cbdf6198-c20e-499c-b910-9bf48577284e",
                            Author = "System",
                            Content = "Comment on short story #2",
                            CreatedAt = new DateTime(2021, 12, 13, 12, 57, 37, 79, DateTimeKind.Local).AddTicks(7483),
                            ShortStoryID = "41613919-ddd8-4db0-badb-68ce5e452bbd"
                        },
                        new
                        {
                            ID = "64400894-44a1-4d48-99ae-238998a122f8",
                            Author = "System",
                            Content = "Comment on short story #3",
                            CreatedAt = new DateTime(2021, 12, 13, 12, 57, 37, 79, DateTimeKind.Local).AddTicks(7527),
                            ShortStoryID = "0604bee3-a6ae-48d3-9473-95fffcc0e310"
                        },
                        new
                        {
                            ID = "b7e20c32-90c9-42ae-b888-5b12059c24de",
                            Author = "System",
                            Content = "Comment on short story #4",
                            CreatedAt = new DateTime(2021, 12, 13, 12, 57, 37, 79, DateTimeKind.Local).AddTicks(7533),
                            ShortStoryID = "8c8c36bd-822f-4041-9b44-bbf0704789a2"
                        });
                });

            modelBuilder.Entity("TermProject.Models.CommentReaction", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnName("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommentID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Reaction")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CommentID");

                    b.ToTable("CommentReaction");
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
                            ID = "0042ae2a-a45f-47cd-84d8-b862d38ba5e9",
                            Author = "System",
                            Content = "Content for short story #1",
                            CreatedAt = new DateTime(2021, 12, 13, 12, 57, 37, 76, DateTimeKind.Local).AddTicks(9705),
                            Title = "Short story #1"
                        },
                        new
                        {
                            ID = "41613919-ddd8-4db0-badb-68ce5e452bbd",
                            Author = "System",
                            Content = "Content for short story #2",
                            CreatedAt = new DateTime(2021, 12, 13, 12, 57, 37, 79, DateTimeKind.Local).AddTicks(5171),
                            Title = "Short story #2"
                        },
                        new
                        {
                            ID = "0604bee3-a6ae-48d3-9473-95fffcc0e310",
                            Author = "System",
                            Content = "Content for short story #3",
                            CreatedAt = new DateTime(2021, 12, 13, 12, 57, 37, 79, DateTimeKind.Local).AddTicks(5266),
                            Title = "Short story #3"
                        },
                        new
                        {
                            ID = "8c8c36bd-822f-4041-9b44-bbf0704789a2",
                            Author = "System",
                            Content = "Content for short story #4",
                            CreatedAt = new DateTime(2021, 12, 13, 12, 57, 37, 79, DateTimeKind.Local).AddTicks(5274),
                            Title = "Short story #4"
                        });
                });

            modelBuilder.Entity("TermProject.Models.ShortStoryReaction", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnName("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Reaction")
                        .HasColumnType("int");

                    b.Property<string>("ShortStoryID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("ShortStoryID");

                    b.ToTable("ShortStoryReactions");
                });

            modelBuilder.Entity("TermProject.Models.Comment", b =>
                {
                    b.HasOne("TermProject.Models.ShortStory", null)
                        .WithMany("Comments")
                        .HasForeignKey("ShortStoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TermProject.Models.CommentReaction", b =>
                {
                    b.HasOne("TermProject.Models.Comment", "Comment")
                        .WithMany("Reactions")
                        .HasForeignKey("CommentID")
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
