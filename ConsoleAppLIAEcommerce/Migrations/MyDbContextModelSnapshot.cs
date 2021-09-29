﻿// <auto-generated />
using System;
using ConsoleAppLIAEcommerce;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConsoleAppLIAEcommerce.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int?>("CategoryId1")
                        .HasColumnType("int");

                    b.Property<string>("CategoryImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.HasIndex("CategoryId1");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            AddDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CategoryImageUrl = "www. dkd",
                            CategoryName = "Mejeri, ost & ägg"
                        },
                        new
                        {
                            CategoryId = 2,
                            AddDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CategoryImageUrl = "www.jdjd",
                            CategoryName = "Vete & Bröd & Pasta"
                        });
                });

            modelBuilder.Entity("ConsoleAppLIAEcommerce.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("OrderStatus")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ShippingDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("WarehouseId")
                        .HasColumnType("int");

                    b.Property<int?>("WarehousesWarehouseId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("WarehousesWarehouseId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ConsoleAppLIAEcommerce.Models.OrderItems", b =>
                {
                    b.Property<int>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("DiscountedPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderItemId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");
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

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PicId");

                    b.HasIndex("ProductId");

                    b.ToTable("Pictures");

                    b.HasData(
                        new
                        {
                            PicId = 1,
                            PicName = "url 1...",
                            ProductId = 3,
                            Url = "www.hdhd"
                        },
                        new
                        {
                            PicId = 2,
                            PicName = "url 2...",
                            ProductId = 2,
                            Url = "www.hdhd"
                        });
                });

            modelBuilder.Entity("ConsoleAppLIAEcommerce.Models.Stocks", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("WarehouseId")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("WarehouseId")
                        .IsUnique();

                    b.ToTable("Stocks");
                });

            modelBuilder.Entity("ConsoleAppLIAEcommerce.Models.Warehouses", b =>
                {
                    b.Property<int>("WarehouseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("WarehouseName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WarehouseId");

                    b.ToTable("Warehouses");
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

                    b.Property<string>("UPC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.Property<double>("Width")
                        .HasColumnType("float");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

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
                            Name = "Ägg",
                            Price = 25.90m,
                            Quantity = 0,
                            RewardPoints = 0,
                            ShortDescription = "Frigående",
                            Status = true,
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
                            Name = "Smör",
                            Price = 10.90m,
                            Quantity = 0,
                            RewardPoints = 0,
                            ShortDescription = "Ekologisk",
                            Status = true,
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
                            Name = "Pasta",
                            Price = 6.50m,
                            Quantity = 0,
                            RewardPoints = 0,
                            ShortDescription = "Fussilli",
                            Status = false,
                            Weight = 0.0,
                            Width = 0.0
                        });
                });

            modelBuilder.Entity("ConsoleAppLIAEcommerce.Models.Category", b =>
                {
                    b.HasOne("ConsoleAppLIAEcommerce.Models.Category", null)
                        .WithMany("Categories")
                        .HasForeignKey("CategoryId1");
                });

            modelBuilder.Entity("ConsoleAppLIAEcommerce.Models.Order", b =>
                {
                    b.HasOne("ConsoleAppLIAEcommerce.Models.Warehouses", "Warehouses")
                        .WithMany("Orders")
                        .HasForeignKey("WarehousesWarehouseId");

                    b.Navigation("Warehouses");
                });

            modelBuilder.Entity("ConsoleAppLIAEcommerce.Models.OrderItems", b =>
                {
                    b.HasOne("ConsoleAppLIAEcommerce.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleAppLIAEcommerce.Product", "Product")
                        .WithMany("OrderItems")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
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

            modelBuilder.Entity("ConsoleAppLIAEcommerce.Models.Stocks", b =>
                {
                    b.HasOne("ConsoleAppLIAEcommerce.Product", "Product")
                        .WithOne("Stocks")
                        .HasForeignKey("ConsoleAppLIAEcommerce.Models.Stocks", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleAppLIAEcommerce.Models.Warehouses", "Warehouses")
                        .WithOne("Stocks")
                        .HasForeignKey("ConsoleAppLIAEcommerce.Models.Stocks", "WarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Warehouses");
                });

            modelBuilder.Entity("ConsoleAppLIAEcommerce.Product", b =>
                {
                    b.HasOne("ConsoleAppLIAEcommerce.Models.Category", null)
                        .WithMany("Product")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("ConsoleAppLIAEcommerce.Models.Category", b =>
                {
                    b.Navigation("Categories");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ConsoleAppLIAEcommerce.Models.Warehouses", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Stocks");
                });

            modelBuilder.Entity("ConsoleAppLIAEcommerce.Product", b =>
                {
                    b.Navigation("OrderItems");

                    b.Navigation("Pictures");

                    b.Navigation("Stocks");
                });
#pragma warning restore 612, 618
        }
    }
}
