﻿// <auto-generated />
using System;
using MRecipes.Api.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MRecipes.Api.Migrations
{
    [DbContext(typeof(MRecipesDbContext))]
    partial class MRecipesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MRecipes.Api.Models.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Article", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"),
                            AuthorId = new Guid("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"),
                            DateAdded = new DateTime(2024, 2, 10, 23, 44, 16, 263, DateTimeKind.Local).AddTicks(8192),
                            Description = "popis",
                            Title = "Olivovy hummus"
                        });
                });

            modelBuilder.Entity("MRecipes.Api.Models.ArticleTag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ArticleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TagId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.HasIndex("TagId");

                    b.ToTable("ArticleTag", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("b2eac1a7-861b-413b-9027-ad57f2731e8b"),
                            ArticleId = new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"),
                            TagId = new Guid("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825")
                        });
                });

            modelBuilder.Entity("MRecipes.Api.Models.Author", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Author", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"),
                            Name = "Admin"
                        });
                });

            modelBuilder.Entity("MRecipes.Api.Models.Ingredient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ArticleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.ToTable("Ingredient", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("c50a3be2-e646-4ca6-a76b-4a2d44a7fcad"),
                            ArticleId = new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"),
                            Name = "sol"
                        });
                });

            modelBuilder.Entity("MRecipes.Api.Models.Step", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ArticleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.ToTable("Step", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("951e4527-ed39-4d1f-942a-a2b0ce374514"),
                            ArticleId = new Guid("a2c30491-5461-4e7f-b13d-d1d9d268206f"),
                            Name = "Krok 1"
                        });
                });

            modelBuilder.Entity("MRecipes.Api.Models.Tag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tag", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825"),
                            Name = "Hlavny chod"
                        },
                        new
                        {
                            Id = new Guid("97892eaf-d414-4717-9bbe-e93ff500c5d4"),
                            Name = "Dezert"
                        },
                        new
                        {
                            Id = new Guid("3da146f8-9fa9-45ae-9cb2-db1b384abeb5"),
                            Name = "Predjedla"
                        },
                        new
                        {
                            Id = new Guid("74b8cc62-8ad7-4c18-b757-ec58b3179a94"),
                            Name = "Salaty"
                        },
                        new
                        {
                            Id = new Guid("1a3121b6-dea5-46ac-a455-394cba93ed94"),
                            Name = "Polievky"
                        },
                        new
                        {
                            Id = new Guid("c77317a2-5d13-4a6b-9388-d7a975234810"),
                            Name = "Napoje"
                        },
                        new
                        {
                            Id = new Guid("7ca5e58f-f270-49f0-86a8-ea3e6f822e5b"),
                            Name = "Bez lepku"
                        },
                        new
                        {
                            Id = new Guid("fd990a33-c6b5-4a86-a2c6-1a9fdc81b0ae"),
                            Name = "Bez laktozy"
                        },
                        new
                        {
                            Id = new Guid("1a092ba2-cff7-4bc8-9989-bf829217a0cf"),
                            Name = "Sladke"
                        });
                });

            modelBuilder.Entity("MRecipes.Api.Models.Article", b =>
                {
                    b.HasOne("MRecipes.Api.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("MRecipes.Api.Models.ArticleTag", b =>
                {
                    b.HasOne("MRecipes.Api.Models.Article", "Article")
                        .WithMany("Tags")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MRecipes.Api.Models.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("MRecipes.Api.Models.Ingredient", b =>
                {
                    b.HasOne("MRecipes.Api.Models.Article", "Article")
                        .WithMany("Ingredients")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");
                });

            modelBuilder.Entity("MRecipes.Api.Models.Step", b =>
                {
                    b.HasOne("MRecipes.Api.Models.Article", "Article")
                        .WithMany("Steps")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");
                });

            modelBuilder.Entity("MRecipes.Api.Models.Article", b =>
                {
                    b.Navigation("Ingredients");

                    b.Navigation("Steps");

                    b.Navigation("Tags");
                });
#pragma warning restore 612, 618
        }
    }
}