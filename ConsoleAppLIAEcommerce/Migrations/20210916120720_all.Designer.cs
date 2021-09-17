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
    [Migration("20210916120720_all")]
    partial class all
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ConsoleAppLIAEcommerce.Models.Picture", b =>
                {
                    b.Property<int>("PicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("PicName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("PicId");

                    b.HasIndex("ProductId");

                    b.ToTable("Pictures");

                    b.HasData(
                        new
                        {
                            PicId = 1,
                            Id = 0,
                            PicName = "url 1..."
                        },
                        new
                        {
                            PicId = 2,
                            Id = 0,
                            PicName = "url 2..."
                        });
                });

            modelBuilder.Entity("ConsoleAppLIAEcommerce.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<string>("UPC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.Property<double>("Width")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
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
                            Weight = 0.0,
                            Width = 0.0
                        },
                        new
                        {
                            Id = 2,
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
                            Weight = 0.0,
                            Width = 0.0
                        },
                        new
                        {
                            Id = 3,
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
                            Weight = 0.0,
                            Width = 0.0
                        });
                });

            modelBuilder.Entity("ConsoleAppLIAEcommerce.Models.Picture", b =>
                {
                    b.HasOne("ConsoleAppLIAEcommerce.Product", "Product")
                        .WithMany("Pictures")
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ConsoleAppLIAEcommerce.Product", b =>
                {
                    b.Navigation("Pictures");
                });
#pragma warning restore 612, 618
        }
    }
}
