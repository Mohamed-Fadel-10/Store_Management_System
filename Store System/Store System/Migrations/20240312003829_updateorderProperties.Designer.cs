﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Store_System.Data;

#nullable disable

namespace Store_System.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20240312003829_updateorderProperties")]
    partial class updateorderProperties
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Store_System.Models.Branch", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("MainMoneyStock")
                        .HasColumnType("float");

                    b.Property<string>("ManagerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Branch");
                });

            modelBuilder.Entity("Store_System.Models.BranchSuppliers", b =>
                {
                    b.Property<int>("Supplier_Id")
                        .HasColumnType("int");

                    b.Property<int>("Branch_Id")
                        .HasColumnType("int");

                    b.Property<int?>("BranchID")
                        .HasColumnType("int");

                    b.Property<int?>("SupplierID")
                        .HasColumnType("int");

                    b.HasKey("Supplier_Id", "Branch_Id");

                    b.HasIndex("BranchID");

                    b.HasIndex("Branch_Id");

                    b.HasIndex("SupplierID");

                    b.ToTable("BranchSuppliers");
                });

            modelBuilder.Entity("Store_System.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Store_System.Models.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Store_System.Models.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("branch_ID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("branch_ID");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("Store_System.Models.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Customer_Id")
                        .HasColumnType("int");

                    b.Property<bool>("IsSale")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ShippedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("user_id")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("Customer_Id");

                    b.HasIndex("user_id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Store_System.Models.OrderItems", b =>
                {
                    b.Property<int>("product_Id")
                        .HasColumnType("int");

                    b.Property<int>("Order_Id")
                        .HasColumnType("int");

                    b.Property<double>("Discount")
                        .HasColumnType("float");

                    b.Property<int?>("OrderID")
                        .HasColumnType("int");

                    b.Property<int?>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.HasKey("product_Id", "Order_Id");

                    b.HasIndex("OrderID");

                    b.HasIndex("Order_Id");

                    b.HasIndex("ProductID");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("Store_System.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Barcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Category_id")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Cost")
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Discount")
                        .HasColumnType("float");

                    b.Property<DateTime?>("Expiry_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Production_Date")
                        .HasColumnType("datetime2");

                    b.Property<double>("SellingPrice")
                        .HasColumnType("float");

                    b.Property<int?>("Size")
                        .HasColumnType("int");

                    b.Property<int>("StockAmount")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("Category_id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Store_System.Models.ProductsStocks", b =>
                {
                    b.Property<int>("Stock_Id")
                        .HasColumnType("int");

                    b.Property<int>("Product_Id")
                        .HasColumnType("int");

                    b.Property<int>("MinQuantity")
                        .HasColumnType("int");

                    b.Property<int?>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("QuantityInStock")
                        .HasColumnType("int");

                    b.Property<int?>("StockID")
                        .HasColumnType("int");

                    b.HasKey("Stock_Id", "Product_Id");

                    b.HasIndex("ProductID");

                    b.HasIndex("Product_Id");

                    b.HasIndex("StockID");

                    b.ToTable("ProductsStocks");
                });

            modelBuilder.Entity("Store_System.Models.ProductsSuppliers", b =>
                {
                    b.Property<int>("product_Id")
                        .HasColumnType("int");

                    b.Property<int>("Supplier_Id")
                        .HasColumnType("int");

                    b.Property<int?>("ProductID")
                        .HasColumnType("int");

                    b.Property<int?>("SupplierID")
                        .HasColumnType("int");

                    b.HasKey("product_Id", "Supplier_Id");

                    b.HasIndex("ProductID");

                    b.HasIndex("SupplierID");

                    b.HasIndex("Supplier_Id");

                    b.ToTable("ProductsSuppliers");
                });

            modelBuilder.Entity("Store_System.Models.Returned", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("Returned");
                });

            modelBuilder.Entity("Store_System.Models.ReturnedItems", b =>
                {
                    b.Property<int>("Returned_Id")
                        .HasColumnType("int");

                    b.Property<int>("Product_Id")
                        .HasColumnType("int");

                    b.Property<int?>("ProductID")
                        .HasColumnType("int");

                    b.Property<int?>("Returnedid")
                        .HasColumnType("int");

                    b.HasKey("Returned_Id", "Product_Id");

                    b.HasIndex("ProductID");

                    b.HasIndex("Product_Id");

                    b.HasIndex("Returnedid");

                    b.ToTable("ReturnedItems");
                });

            modelBuilder.Entity("Store_System.Models.Stock", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StockManager")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Stock");
                });

            modelBuilder.Entity("Store_System.Models.Supplier", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ContractDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Supplier");
                });

            modelBuilder.Entity("Store_System.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("Branch_Id")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("MoneyStockAmount")
                        .HasColumnType("float");

                    b.Property<string>("MoneyStockName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("Branch_Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Store_System.Models.BranchSuppliers", b =>
                {
                    b.HasOne("Store_System.Models.Branch", null)
                        .WithMany("branchSuppliers")
                        .HasForeignKey("BranchID");

                    b.HasOne("Store_System.Models.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("Branch_Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Store_System.Models.Supplier", null)
                        .WithMany("branchSuppliers")
                        .HasForeignKey("SupplierID");

                    b.HasOne("Store_System.Models.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("Supplier_Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Branch");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("Store_System.Models.Employee", b =>
                {
                    b.HasOne("Store_System.Models.Branch", "Branch")
                        .WithMany("Employees")
                        .HasForeignKey("branch_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("Store_System.Models.Order", b =>
                {
                    b.HasOne("Store_System.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("Customer_Id");

                    b.HasOne("Store_System.Models.User", "user")
                        .WithMany("Orders")
                        .HasForeignKey("user_id");

                    b.Navigation("Customer");

                    b.Navigation("user");
                });

            modelBuilder.Entity("Store_System.Models.OrderItems", b =>
                {
                    b.HasOne("Store_System.Models.Order", null)
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderID");

                    b.HasOne("Store_System.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("Order_Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Store_System.Models.Product", null)
                        .WithMany("OrderItems")
                        .HasForeignKey("ProductID");

                    b.HasOne("Store_System.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("product_Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Store_System.Models.Product", b =>
                {
                    b.HasOne("Store_System.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("Category_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Store_System.Models.ProductsStocks", b =>
                {
                    b.HasOne("Store_System.Models.Product", null)
                        .WithMany("ProductsStocks")
                        .HasForeignKey("ProductID");

                    b.HasOne("Store_System.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("Product_Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Store_System.Models.Stock", null)
                        .WithMany("ProductsStocks")
                        .HasForeignKey("StockID");

                    b.HasOne("Store_System.Models.Stock", "Stock")
                        .WithMany()
                        .HasForeignKey("Stock_Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Stock");
                });

            modelBuilder.Entity("Store_System.Models.ProductsSuppliers", b =>
                {
                    b.HasOne("Store_System.Models.Product", null)
                        .WithMany("ProductsSuppliers")
                        .HasForeignKey("ProductID");

                    b.HasOne("Store_System.Models.Supplier", null)
                        .WithMany("ProductsSuppliers")
                        .HasForeignKey("SupplierID");

                    b.HasOne("Store_System.Models.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("Supplier_Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Store_System.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("product_Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("Store_System.Models.ReturnedItems", b =>
                {
                    b.HasOne("Store_System.Models.Product", null)
                        .WithMany("ReturnedItems")
                        .HasForeignKey("ProductID");

                    b.HasOne("Store_System.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("Product_Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Store_System.Models.Returned", "Returned")
                        .WithMany()
                        .HasForeignKey("Returned_Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Store_System.Models.Returned", null)
                        .WithMany("ReturnedItems")
                        .HasForeignKey("Returnedid");

                    b.Navigation("Product");

                    b.Navigation("Returned");
                });

            modelBuilder.Entity("Store_System.Models.User", b =>
                {
                    b.HasOne("Store_System.Models.Branch", "Branch")
                        .WithMany("Users")
                        .HasForeignKey("Branch_Id");

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("Store_System.Models.Branch", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Users");

                    b.Navigation("branchSuppliers");
                });

            modelBuilder.Entity("Store_System.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Store_System.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Store_System.Models.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("Store_System.Models.Product", b =>
                {
                    b.Navigation("OrderItems");

                    b.Navigation("ProductsStocks");

                    b.Navigation("ProductsSuppliers");

                    b.Navigation("ReturnedItems");
                });

            modelBuilder.Entity("Store_System.Models.Returned", b =>
                {
                    b.Navigation("ReturnedItems");
                });

            modelBuilder.Entity("Store_System.Models.Stock", b =>
                {
                    b.Navigation("ProductsStocks");
                });

            modelBuilder.Entity("Store_System.Models.Supplier", b =>
                {
                    b.Navigation("ProductsSuppliers");

                    b.Navigation("branchSuppliers");
                });

            modelBuilder.Entity("Store_System.Models.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
