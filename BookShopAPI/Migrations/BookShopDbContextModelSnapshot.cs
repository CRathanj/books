﻿// <auto-generated />
using System;
using BookShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookShop.Migrations
{
    [DbContext(typeof(BookShopDbContext))]
    partial class BookShopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BookShop.Models.Book", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("id");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("author");

                    b.Property<DateTime?>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasColumnName("date_created")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .HasColumnName("description");

                    b.Property<int>("Genres")
                        .HasMaxLength(11)
                        .HasColumnType("int")
                        .HasColumnName("genres");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("isbn");

                    b.Property<DateTime?>("LastUpdatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasColumnName("date_modified")
                        .HasDefaultValueSql("NULL ON UPDATE CURRENT_TIMESTAMP");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("name");

                    b.Property<decimal>("Price")
                        .HasColumnType("DECIMAL(15,3)")
                        .HasColumnName("price");

                    b.Property<DateTime?>("PublishDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasColumnName("date_publish")
                        .HasDefaultValueSql("NULL");

                    b.HasKey("Id");

                    b.ToTable("books", (string)null);
                });

            modelBuilder.Entity("BookShopAPI.Models.Customer", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("id");

                    b.Property<string>("Address")
                        .HasMaxLength(150)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("address");

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("contact");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("customers", (string)null);
                });

            modelBuilder.Entity("BookShopAPI.Models.Employee", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("id");

                    b.Property<ulong>("Active")
                        .HasColumnType("bit")
                        .HasColumnName("active");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("address");

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("contact");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("gender");

                    b.Property<DateTime>("HireDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasColumnName("hire_date")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("name");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("position");

                    b.Property<decimal>("Salary")
                        .HasColumnType("DECIMAL(15,3)")
                        .HasColumnName("salary");

                    b.Property<DateTime?>("StopDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasColumnName("stop_date")
                        .HasDefaultValueSql("NULL ON UPDATE CURRENT_TIMESTAMP");

                    b.HasKey("Id");

                    b.ToTable("employees", (string)null);
                });

            modelBuilder.Entity("BookShopAPI.Models.Sale", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("id");

                    b.Property<DateTime?>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasColumnName("date_created")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnType("VARCHAR(36)");

                    b.Property<string>("EmployeeId")
                        .IsRequired()
                        .HasColumnType("VARCHAR(36)");

                    b.Property<DateTime?>("LastUpdatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasColumnName("date_modified")
                        .HasDefaultValueSql("NULL ON UPDATE CURRENT_TIMESTAMP");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("sales", (string)null);
                });

            modelBuilder.Entity("BookShopAPI.Models.SaleDetail", b =>
                {
                    b.Property<string>("SaleId")
                        .HasColumnType("VARCHAR(36)");

                    b.Property<string>("BookId")
                        .HasColumnType("VARCHAR(36)");

                    b.Property<decimal>("Amount")
                        .HasColumnType("DECIMAL(15,3)")
                        .HasColumnName("amount");

                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("id");

                    b.Property<int>("Quantity")
                        .HasMaxLength(11)
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.HasKey("SaleId", "BookId");

                    b.HasIndex("BookId");

                    b.ToTable("sale_details", (string)null);
                });

            modelBuilder.Entity("BookShopAPI.Models.Sale", b =>
                {
                    b.HasOne("BookShopAPI.Models.Customer", "Customer")
                        .WithMany("Sales")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookShopAPI.Models.Employee", "Employee")
                        .WithMany("Sales")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("BookShopAPI.Models.SaleDetail", b =>
                {
                    b.HasOne("BookShop.Models.Book", "Book")
                        .WithMany("SaleDetails")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("book_id");

                    b.HasOne("BookShopAPI.Models.Sale", "Sale")
                        .WithMany("SaleDetails")
                        .HasForeignKey("SaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("sale_id");

                    b.Navigation("Book");

                    b.Navigation("Sale");
                });

            modelBuilder.Entity("BookShop.Models.Book", b =>
                {
                    b.Navigation("SaleDetails");
                });

            modelBuilder.Entity("BookShopAPI.Models.Customer", b =>
                {
                    b.Navigation("Sales");
                });

            modelBuilder.Entity("BookShopAPI.Models.Employee", b =>
                {
                    b.Navigation("Sales");
                });

            modelBuilder.Entity("BookShopAPI.Models.Sale", b =>
                {
                    b.Navigation("SaleDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
