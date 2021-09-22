﻿// <auto-generated />
using System;
using ConsoleAppLIAEcommerce;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConsoleAppLIAEcommerce.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20210921234907_seed")]
    partial class seed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ConsoleAppLIAEcommerce.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            AddDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CategoryName = "Mejeri, ost & ägg"
                        },
                        new
                        {
                            CategoryId = 2,
                            AddDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CategoryName = "Vete & Bröd & Pasta"
                        });
                });

            modelBuilder.Entity("ConsoleAppLIAEcommerce.Models.Picture", b =>
                {
                    b.Property<int>("PicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PicName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("PicId");

                    b.HasIndex("ProductId");

                    b.ToTable("Pictures");

                    b.HasData(
                        new
                        {
                            PicId = 1,
                            PicName = "url 1...",
                            ProductId = 3
                        },
                        new
                        {
                            PicId = 2,
                            PicName = "url 2...",
                            ProductId = 2
                        });
                });

            modelBuilder.Entity("ConsoleAppLIAEcommerce.Models.SubCategory", b =>
                {
                    b.Property<int>("SubCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SubCategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubCategoryId");

                    b.ToTable("SubCategories");

                    b.HasData(
                        new
                        {
                            SubCategoryId = 1,
                            SubCategoryName = "Mejeri"
                        },
                        new
                        {
                            SubCategoryId = 2,
                            SubCategoryName = "Ägg"
                        },
                        new
                        {
                            SubCategoryId = 3,
                            SubCategoryName = "Pasta & Noodles"
                        });
                });

            modelBuilder.Entity("ConsoleAppLIAEcommerce.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("DiscountedPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<double>("Length")
                        .HasColumnType("float");

                    b.Property<string>("MainImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MinimumQuantity")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MyProperty")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("RewardPoints")
                        .HasColumnType("int");

                    b.Property<string>("SKU")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("SubCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("UPC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.Property<double>("Width")
                        .HasColumnType("float");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SubCategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            AddDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Land: Sverige",
                            DiscountedPrice = 19.90m,
                            Height = 0.0,
                            Length = 0.0,
                            MinimumQuantity = 0,
                            MyProperty = 0,
                            Name = "Ägg",
                            Price = 25.90m,
                            Quantity = 0,
                            RewardPoints = 0,
                            ShortDescription = "Frigående",
                            Status = true,
                            SubCategoryId = 2,
                            Weight = 0.0,
                            Width = 0.0
                        },
                        new
                        {
                            ProductId = 2,
                            AddDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Land: Tyskland",
                            DiscountedPrice = 7.50m,
                            Height = 0.0,
                            Length = 0.0,
                            MinimumQuantity = 0,
                            MyProperty = 0,
                            Name = "Smör",
                            Price = 10.90m,
                            Quantity = 0,
                            RewardPoints = 0,
                            ShortDescription = "Ekologisk",
                            Status = true,
                            SubCategoryId = 1,
                            Weight = 0.0,
                            Width = 0.0
                        },
                        new
                        {
                            ProductId = 3,
                            AddDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Land: Italien",
                            DiscountedPrice = 4.50m,
                            Height = 0.0,
                            Length = 0.0,
                            MinimumQuantity = 0,
                            MyProperty = 0,
                            Name = "Pasta",
                            Price = 6.50m,
                            Quantity = 0,
                            RewardPoints = 0,
                            ShortDescription = "Fussilli",
                            Status = false,
                            SubCategoryId = 3,
                            Weight = 0.0,
                            Width = 0.0
                        });
                });

            modelBuilder.Entity("ConsoleAppLIAEcommerce.Models.Picture", b =>
                {
                    b.HasOne("ConsoleAppLIAEcommerce.Product", "Product")
                        .WithMany("Pictures")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ConsoleAppLIAEcommerce.Product", b =>
                {
                    b.HasOne("ConsoleAppLIAEcommerce.Models.Category", null)
                        .WithMany("Product")
                        .HasForeignKey("CategoryId");

                    b.HasOne("ConsoleAppLIAEcommerce.Models.SubCategory", "SubCategory")
                        .WithMany("Products")
                        .HasForeignKey("SubCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("ConsoleAppLIAEcommerce.Models.Category", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("ConsoleAppLIAEcommerce.Models.SubCategory", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("ConsoleAppLIAEcommerce.Product", b =>
                {
                    b.Navigation("Pictures");
                });
#pragma warning restore 612, 618
        }
    }
}
