﻿// <auto-generated />
using System;
using ECommerceApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ECommerceApi.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ECommerceApi.Data.Customer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("DeleteDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTimeOffset>("UpdateDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Address = "Oak St, Los Angeles, CA 90403",
                            CreationDate = new DateTimeOffset(new DateTime(2024, 4, 17, 7, 44, 40, 923, DateTimeKind.Unspecified).AddTicks(1186), new TimeSpan(0, 0, 0, 0, 0)),
                            DeleteDate = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Email = "alex.smith@example.com",
                            IsDeleted = false,
                            Name = "Alex Smith",
                            UpdateDate = new DateTimeOffset(new DateTime(2024, 4, 17, 7, 44, 40, 923, DateTimeKind.Unspecified).AddTicks(1187), new TimeSpan(0, 0, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("ECommerceApi.Data.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTimeOffset>("CreationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<long>("CustomerId")
                        .HasColumnType("bigint");

                    b.Property<DateTimeOffset>("DeleteDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTimeOffset>("UpdateDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ECommerceApi.Data.OrderDetail", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTimeOffset>("CreationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("DeleteDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<long>("OrderId")
                        .HasColumnType("bigint");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("SubtotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTimeOffset>("UpdateDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("ECommerceApi.Data.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTimeOffset>("CreationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("DeleteDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<int>("UnitPrice")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("UpdateDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ECommerceApi.Data.ProductCategory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTimeOffset>("CreationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("DeleteDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTimeOffset>("UpdateDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreationDate = new DateTimeOffset(new DateTime(2024, 4, 17, 7, 44, 40, 923, DateTimeKind.Unspecified).AddTicks(948), new TimeSpan(0, 0, 0, 0, 0)),
                            DeleteDate = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "Shoes for various sports activities",
                            IsDeleted = false,
                            Name = "Sport Shoes",
                            UpdateDate = new DateTimeOffset(new DateTime(2024, 4, 17, 7, 44, 40, 923, DateTimeKind.Unspecified).AddTicks(950), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = 2L,
                            CreationDate = new DateTimeOffset(new DateTime(2024, 4, 17, 7, 44, 40, 923, DateTimeKind.Unspecified).AddTicks(954), new TimeSpan(0, 0, 0, 0, 0)),
                            DeleteDate = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "Shirts for sports enthusiasts",
                            IsDeleted = false,
                            Name = "Sport Shirt",
                            UpdateDate = new DateTimeOffset(new DateTime(2024, 4, 17, 7, 44, 40, 923, DateTimeKind.Unspecified).AddTicks(955), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = 3L,
                            CreationDate = new DateTimeOffset(new DateTime(2024, 4, 17, 7, 44, 40, 923, DateTimeKind.Unspecified).AddTicks(958), new TimeSpan(0, 0, 0, 0, 0)),
                            DeleteDate = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "Pants suitable for sports",
                            IsDeleted = false,
                            Name = "Sport Pants",
                            UpdateDate = new DateTimeOffset(new DateTime(2024, 4, 17, 7, 44, 40, 923, DateTimeKind.Unspecified).AddTicks(959), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = 4L,
                            CreationDate = new DateTimeOffset(new DateTime(2024, 4, 17, 7, 44, 40, 923, DateTimeKind.Unspecified).AddTicks(961), new TimeSpan(0, 0, 0, 0, 0)),
                            DeleteDate = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "Accessories for sports",
                            IsDeleted = false,
                            Name = "Sport Accessories",
                            UpdateDate = new DateTimeOffset(new DateTime(2024, 4, 17, 7, 44, 40, 923, DateTimeKind.Unspecified).AddTicks(962), new TimeSpan(0, 0, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("ProductProductCategory", b =>
                {
                    b.Property<long>("ProductCategoriesId")
                        .HasColumnType("bigint");

                    b.Property<long>("ProductsId")
                        .HasColumnType("bigint");

                    b.HasKey("ProductCategoriesId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("ProductsCategoryAssociation", (string)null);
                });

            modelBuilder.Entity("ECommerceApi.Data.Order", b =>
                {
                    b.HasOne("ECommerceApi.Data.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("ECommerceApi.Data.OrderDetail", b =>
                {
                    b.HasOne("ECommerceApi.Data.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECommerceApi.Data.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ProductProductCategory", b =>
                {
                    b.HasOne("ECommerceApi.Data.ProductCategory", null)
                        .WithMany()
                        .HasForeignKey("ProductCategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECommerceApi.Data.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ECommerceApi.Data.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("ECommerceApi.Data.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
