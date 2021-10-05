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

            modelBuilder.Entity("ConsoleAppLIAEcommerce.Models.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Postcode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddressId");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.ToTable("Addresses");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Address");
                });

            modelBuilder.Entity("ConsoleAppLIAEcommerce.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telephone")
                        .HasColumnType("int");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("ConsoleAppLIAEcommerce.Models.ProductTag", b =>
                {
                    b.Property<int>("ProductTagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("ProductTagId");

                    b.HasIndex("ProductId");

                    b.HasIndex("TagId");

                    b.ToTable("ProductTags");
                });

            modelBuilder.Entity("ConsoleAppLIAEcommerce.Models.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TagId");

                    b.ToTable("Tags");
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
                            Id = 3,
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
                            Id = 4,
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
                            Id = 5,
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

            modelBuilder.Entity("ConsoleAppLIAEcommerce.Models.Shipping", b =>
                {
                    b.HasBaseType("ConsoleAppLIAEcommerce.Models.Address");

                    b.Property<bool>("IsBillingAddressTheSame")
                        .HasColumnType("bit");

                    b.HasDiscriminator().HasValue("Shipping");
                });

            modelBuilder.Entity("ConsoleAppLIAEcommerce.Models.Address", b =>
                {
                    b.HasOne("ConsoleAppLIAEcommerce.Models.Customer", "Customer")
                        .WithOne("Address")
                        .HasForeignKey("ConsoleAppLIAEcommerce.Models.Address", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("ConsoleAppLIAEcommerce.Models.ProductTag", b =>
                {
                    b.HasOne("ConsoleAppLIAEcommerce.Product", "Product")
                        .WithMany("ProductTags")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleAppLIAEcommerce.Models.Tag", "Tag")
                        .WithMany("ProductTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("ConsoleAppLIAEcommerce.Models.Customer", b =>
                {
                    b.Navigation("Address");
                });

            modelBuilder.Entity("ConsoleAppLIAEcommerce.Models.Tag", b =>
                {
                    b.Navigation("ProductTags");
                });

            modelBuilder.Entity("ConsoleAppLIAEcommerce.Product", b =>
                {
                    b.Navigation("ProductTags");
                });
#pragma warning restore 612, 618
        }
    }
}
