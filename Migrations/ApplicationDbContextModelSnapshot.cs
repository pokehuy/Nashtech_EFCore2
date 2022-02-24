﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using efcore2.Repository;

#nullable disable

namespace efcore2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("efcore2.Models.CategoryModel", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Books"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Smartphones"
                        });
                });

            modelBuilder.Entity("efcore2.Models.ProductModel", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Manufacture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            Manufacture = "Oxford",
                            ProductName = "English"
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            Manufacture = "Duden",
                            ProductName = "German"
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 1,
                            Manufacture = "Tuoitre",
                            ProductName = "Tieng Viet"
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 2,
                            Manufacture = "Apple",
                            ProductName = "iPhone 20"
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 2,
                            Manufacture = "Apple",
                            ProductName = "iPhone 21"
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 2,
                            Manufacture = "Samsung",
                            ProductName = "Galaxy 100"
                        });
                });

            modelBuilder.Entity("efcore2.Models.ProductModel", b =>
                {
                    b.HasOne("efcore2.Models.CategoryModel", null)
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
