// <auto-generated />
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
    [Migration("20211213173302_FinalizedReactions2")]
    partial class FinalizedReactions2
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
                            ID = "16e7fbf5-a77a-49ac-8c96-33da1083e489",
                            Author = "System",
                            Content = "Comment on short story #1",
                            CreatedAt = new DateTime(2021, 12, 13, 12, 33, 2, 30, DateTimeKind.Local).AddTicks(2334),
                            ShortStoryID = "f241ce49-1a4b-4639-a0c8-3044c049bcd4"
                        },
                        new
                        {
                            ID = "d0b5384d-645d-48ae-a053-9fd44a6d4ba6",
                            Author = "System",
                            Content = "Comment on short story #2",
                            CreatedAt = new DateTime(2021, 12, 13, 12, 33, 2, 30, DateTimeKind.Local).AddTicks(3396),
                            ShortStoryID = "00864378-27c4-4578-b04a-80f37f842ebf"
                        },
                        new
                        {
                            ID = "a140bbd4-2f37-4e61-a0e5-525b6b43be76",
                            Author = "System",
                            Content = "Comment on short story #3",
                            CreatedAt = new DateTime(2021, 12, 13, 12, 33, 2, 30, DateTimeKind.Local).AddTicks(3444),
                            ShortStoryID = "7666cc7c-43c3-4a61-ba27-df1d29058f6b"
                        },
                        new
                        {
                            ID = "7ad6d37d-6493-4941-9763-723a631db603",
                            Author = "System",
                            Content = "Comment on short story #4",
                            CreatedAt = new DateTime(2021, 12, 13, 12, 33, 2, 30, DateTimeKind.Local).AddTicks(3451),
                            ShortStoryID = "fabfd36a-823e-49f2-92c7-33e85827f123"
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
                            ID = "f241ce49-1a4b-4639-a0c8-3044c049bcd4",
                            Author = "System",
                            Content = "Content for short story #1",
                            CreatedAt = new DateTime(2021, 12, 13, 12, 33, 2, 27, DateTimeKind.Local).AddTicks(6409),
                            Title = "Short story #1"
                        },
                        new
                        {
                            ID = "00864378-27c4-4578-b04a-80f37f842ebf",
                            Author = "System",
                            Content = "Content for short story #2",
                            CreatedAt = new DateTime(2021, 12, 13, 12, 33, 2, 30, DateTimeKind.Local).AddTicks(1192),
                            Title = "Short story #2"
                        },
                        new
                        {
                            ID = "7666cc7c-43c3-4a61-ba27-df1d29058f6b",
                            Author = "System",
                            Content = "Content for short story #3",
                            CreatedAt = new DateTime(2021, 12, 13, 12, 33, 2, 30, DateTimeKind.Local).AddTicks(1238),
                            Title = "Short story #3"
                        },
                        new
                        {
                            ID = "fabfd36a-823e-49f2-92c7-33e85827f123",
                            Author = "System",
                            Content = "Content for short story #4",
                            CreatedAt = new DateTime(2021, 12, 13, 12, 33, 2, 30, DateTimeKind.Local).AddTicks(1245),
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
