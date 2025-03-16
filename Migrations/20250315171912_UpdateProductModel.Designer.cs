﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using catalogo_producto_api.Database;

#nullable disable

namespace catalogo_producto_api.Migrations
{
    [DbContext(typeof(ApplicationDatabaseContext))]
    [Migration("20250315171912_UpdateProductModel")]
    partial class UpdateProductModel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("catalogo_producto_api.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Description");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ImageURL");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)")
                        .HasColumnName("Price");

                    b.Property<int>("Stock")
                        .HasColumnType("int")
                        .HasColumnName("Stock");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
