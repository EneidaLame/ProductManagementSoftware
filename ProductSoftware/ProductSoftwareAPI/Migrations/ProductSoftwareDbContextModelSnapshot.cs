﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductSoftwareAPI.Data;

#nullable disable

namespace ProductSoftwareAPI.Migrations
{
    [DbContext(typeof(ProductSoftwareDbContext))]
    partial class ProductSoftwareDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProductSoftwareAPI.Entities.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Carts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("ProductSoftwareAPI.Entities.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("ProductSoftwareAPI.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Acer Monitors",
                            ImageUrl = "/Images/Monitors/1.jpg",
                            Name = "Monitor",
                            Price = 200m,
                            Qty = 10
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Omen Monitors",
                            ImageUrl = "/Images/Monitors/2.png",
                            Name = "Monitor",
                            Price = 400m,
                            Qty = 45
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Gaiming Monitor",
                            ImageUrl = "/Images/Monitors/3.jpg",
                            Name = "Monitor",
                            Price = 200m,
                            Qty = 30
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "GamingMonitors",
                            ImageUrl = "/Images/Monitors/4.png",
                            Name = "Monitor",
                            Price = 700m,
                            Qty = 30
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Description = "Curved Monitors",
                            ImageUrl = "/Images/Monitors/5.jpg",
                            Name = "Monitor",
                            Price = 500m,
                            Qty = 100
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            Description = "Monitors",
                            ImageUrl = "/Images/Monitors/6.jpg",
                            Name = "Monitor",
                            Price = 400m,
                            Qty = 11
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            Description = "Desktop",
                            ImageUrl = "/Images/Desktop/1.jpg",
                            Name = "Desktop",
                            Price = 1000m,
                            Qty = 120
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            Description = "Desktop",
                            ImageUrl = "/Images/Desktop/2.jpeg",
                            Name = "Desktop",
                            Price = 400m,
                            Qty = 200
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 2,
                            Description = "Desktop",
                            ImageUrl = "/Images/Desktop/3.jpg",
                            Name = "Desktop",
                            Price = 600m,
                            Qty = 300
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 2,
                            Description = "Desktop",
                            ImageUrl = "/Images/Desktop/4.jpeg",
                            Name = "Desktop",
                            Price = 800m,
                            Qty = 30
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 2,
                            Description = "Desktop",
                            ImageUrl = "/Images/Desktop/5.jpg",
                            Name = "Desktop",
                            Price = 800m,
                            Qty = 90
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 2,
                            Description = "Desktop",
                            ImageUrl = "/Images/Desktop/6.jpg",
                            Name = "Desktop",
                            Price = 1000m,
                            Qty = 200
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 3,
                            Description = "Laptop",
                            ImageUrl = "/Images/Laptops/1.jpeg",
                            Name = "Laptop",
                            Price = 500m,
                            Qty = 212
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 3,
                            Description = "Laptop",
                            ImageUrl = "/Images/Laptops/2.jpg",
                            Name = "Laptop",
                            Price = 760m,
                            Qty = 112
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 3,
                            Description = "Laptop",
                            ImageUrl = "/Images/Laptops/3.jpeg",
                            Name = "Laptop",
                            Price = 700m,
                            Qty = 90
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 3,
                            Description = "Laptop",
                            ImageUrl = "/Images/Laptops/4.jpg",
                            Name = "Laptop",
                            Price = 900m,
                            Qty = 65
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 3,
                            Description = "Laptop",
                            ImageUrl = "/Images/Laptops/5.jpeg",
                            Name = "Laptop",
                            Price = 400m,
                            Qty = 22
                        });
                });

            modelBuilder.Entity("ProductSoftwareAPI.Entities.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("IconCSS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IconCSS = "fa fa-television",
                            Name = "Monitors"
                        },
                        new
                        {
                            Id = 2,
                            IconCSS = "fa fa-desktop",
                            Name = "Desktops"
                        },
                        new
                        {
                            Id = 3,
                            IconCSS = "fa fa-laptop",
                            Name = "Laptops"
                        });
                });

            modelBuilder.Entity("ProductSoftwareAPI.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserName = "Maria"
                        },
                        new
                        {
                            Id = 2,
                            UserName = "Xristina"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
