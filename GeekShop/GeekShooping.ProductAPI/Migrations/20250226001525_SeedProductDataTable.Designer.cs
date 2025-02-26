﻿// <auto-generated />
using GeekShooping.ProductAPI.Model.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GeekShooping.ProductAPI.Migrations
{
    [DbContext(typeof(GSContext))]
    [Migration("20250226001525_SeedProductDataTable")]
    partial class SeedProductDataTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GeekShooping.ProductAPI.Model.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("category_name");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("description");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)")
                        .HasColumnName("image_url");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("price");

                    b.HasKey("Id");

                    b.ToTable("product");

                    b.HasData(
                        new
                        {
                            Id = 2L,
                            CategoryName = "Educação",
                            Description = "Curso para aperfeiçoamento do desenvolvimento de aplicações Web, com HTML, CSS e Javascript",
                            ImageURL = "https://github.com/tavinlima/SPODWE1/blob/main/src/img/meta_img.png?raw=true",
                            Name = "Curso de desenvolvimento Web II",
                            Price = 29.9m
                        },
                        new
                        {
                            Id = 3L,
                            CategoryName = "Educação",
                            Description = "Curso para aperfeiçoamento do desenvolvimento de aplicações Web, com HTML, CSS e Javascript",
                            ImageURL = "https://github.com/tavinlima/SPODWE1/blob/main/src/img/meta_img.png?raw=true",
                            Name = "Curso de desenvolvimento Web III",
                            Price = 29.9m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
