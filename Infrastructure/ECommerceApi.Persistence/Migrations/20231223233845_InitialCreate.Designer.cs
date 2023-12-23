﻿// <auto-generated />
using System;
using ECommerceApi.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ECommerceApi.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231223233845_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CategoryEntityProductEntity", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("integer");

                    b.Property<int>("ProductsId")
                        .HasColumnType("integer");

                    b.HasKey("CategoriesId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("CategoryEntityProductEntity");
                });

            modelBuilder.Entity("ECommerceApi.Domain.Entities.BrandEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 12, 24, 2, 38, 44, 701, DateTimeKind.Local).AddTicks(3088),
                            IsDeleted = false,
                            Name = "Games"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 12, 24, 2, 38, 44, 701, DateTimeKind.Local).AddTicks(3131),
                            IsDeleted = false,
                            Name = "Garden, Electronics & Outdoors"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 12, 24, 2, 38, 44, 701, DateTimeKind.Local).AddTicks(3148),
                            IsDeleted = true,
                            Name = "Beauty, Movies & Automotive"
                        });
                });

            modelBuilder.Entity("ECommerceApi.Domain.Entities.CategoryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ParentId")
                        .HasColumnType("integer");

                    b.Property<int>("Priorty")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 12, 24, 2, 38, 44, 701, DateTimeKind.Local).AddTicks(4412),
                            IsDeleted = false,
                            Name = "Elektronik",
                            ParentId = 0,
                            Priorty = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 12, 24, 2, 38, 44, 701, DateTimeKind.Local).AddTicks(4413),
                            IsDeleted = false,
                            Name = "Moda",
                            ParentId = 0,
                            Priorty = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 12, 24, 2, 38, 44, 701, DateTimeKind.Local).AddTicks(4415),
                            IsDeleted = false,
                            Name = "Bilgisayar",
                            ParentId = 1,
                            Priorty = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2023, 12, 24, 2, 38, 44, 701, DateTimeKind.Local).AddTicks(4416),
                            IsDeleted = false,
                            Name = "Kadın",
                            ParentId = 2,
                            Priorty = 1
                        });
                });

            modelBuilder.Entity("ECommerceApi.Domain.Entities.DetailEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Details");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2023, 12, 24, 2, 38, 44, 702, DateTimeKind.Local).AddTicks(9996),
                            Description = "Olduğu exercitationem beatae aut non.",
                            IsDeleted = false,
                            Title = "Dignissimos."
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2023, 12, 24, 2, 38, 44, 703, DateTimeKind.Local).AddTicks(22),
                            Description = "Aut aliquid orta et ea.",
                            IsDeleted = true,
                            Title = "Ut çobanın."
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 4,
                            CreatedDate = new DateTime(2023, 12, 24, 2, 38, 44, 703, DateTimeKind.Local).AddTicks(44),
                            Description = "Quia salladı enim neque nisi.",
                            IsDeleted = false,
                            Title = "Gitti."
                        });
                });

            modelBuilder.Entity("ECommerceApi.Domain.Entities.ProductEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("BrandId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Discount")
                        .HasColumnType("numeric");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 1,
                            CreatedDate = new DateTime(2023, 12, 24, 2, 38, 44, 704, DateTimeKind.Local).AddTicks(5310),
                            Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            Discount = 3.683204475058420m,
                            IsDeleted = false,
                            Price = 251.73m,
                            Title = "Ergonomic Steel Computer"
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 1,
                            CreatedDate = new DateTime(2023, 12, 24, 2, 38, 44, 704, DateTimeKind.Local).AddTicks(5332),
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Discount = 6.00052208791810m,
                            IsDeleted = false,
                            Price = 163.35m,
                            Title = "Intelligent Wooden Table"
                        });
                });

            modelBuilder.Entity("CategoryEntityProductEntity", b =>
                {
                    b.HasOne("ECommerceApi.Domain.Entities.CategoryEntity", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECommerceApi.Domain.Entities.ProductEntity", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ECommerceApi.Domain.Entities.DetailEntity", b =>
                {
                    b.HasOne("ECommerceApi.Domain.Entities.CategoryEntity", "Category")
                        .WithMany("Details")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ECommerceApi.Domain.Entities.ProductEntity", b =>
                {
                    b.HasOne("ECommerceApi.Domain.Entities.BrandEntity", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("ECommerceApi.Domain.Entities.CategoryEntity", b =>
                {
                    b.Navigation("Details");
                });
#pragma warning restore 612, 618
        }
    }
}
