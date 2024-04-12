using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Store_System.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_System.Data
{
    internal class StoreContext:DbContext
    {
        public StoreContext()
        {
            
        }
        public StoreContext(DbContextOptions options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<OrderItems>()
                .HasOne(oi => oi.Order)
                .WithMany(o => o.OrderItems)
                .HasForeignKey(oi => oi.Order_Id)
                .OnDelete(DeleteBehavior.Cascade); 

            modelBuilder.Entity<OrderItems>()
                .HasOne(oi => oi.Product)
                .WithMany(o=>o.OrderItems)
                .HasForeignKey(oi => oi.product_Id)
                .OnDelete(DeleteBehavior.NoAction);


            /// ProductsSuppliers
            modelBuilder.Entity<ProductsSuppliers>()
           .HasKey(ps => new { ps.product_Id, ps.Supplier_Id });

            modelBuilder.Entity<ProductsSuppliers>()
                .HasOne(ps => ps.Product)
                .WithMany()
                .HasForeignKey(ps => ps.product_Id)
                  .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<ProductsSuppliers>()
                .HasOne(ps => ps.Supplier)
                .WithMany()
                .HasForeignKey(ps => ps.Supplier_Id).OnDelete(DeleteBehavior.NoAction);


            ///========================
            modelBuilder.Entity<BranchSuppliers>()
            .HasKey(ps => new { ps.Supplier_Id, ps.Branch_Id });

            modelBuilder.Entity<BranchSuppliers>()
                .HasOne(ps => ps.Branch)
                .WithMany()
                .HasForeignKey(ps => ps.Branch_Id).OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<BranchSuppliers>()
                .HasOne(ps => ps.Supplier)
                .WithMany()
                .HasForeignKey(ps => ps.Supplier_Id).OnDelete(DeleteBehavior.NoAction);


            //================================
            modelBuilder.Entity<ReturnedItems>()
            .HasKey(ps => new { ps.Returned_Id, ps.Product_Id });

            modelBuilder.Entity<ReturnedItems>()
                .HasOne(ps => ps.Product)
                .WithMany()
                .HasForeignKey(ps => ps.Product_Id)
                .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<ReturnedItems>()
                .HasOne(ps => ps.Returned)
                .WithMany()
                .HasForeignKey(ps => ps.Returned_Id).OnDelete(DeleteBehavior.NoAction);

            //===========================================
            modelBuilder.Entity<ProductsStocks>()
            .HasKey(ps => new { ps.Stock_Id, ps.Product_Id });

            modelBuilder.Entity<ProductsStocks>()
                .HasOne(ps => ps.Product)
                .WithMany()
                .HasForeignKey(ps => ps.Product_Id).OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<ProductsStocks>()
                .HasOne(ps => ps.Stock)
                .WithMany()
                .HasForeignKey(ps => ps.Stock_Id).OnDelete(DeleteBehavior.NoAction);

            base.OnModelCreating(modelBuilder);
        }
       
        /// Configurations

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {


                IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("defaultconnection"));

                base.OnConfiguring(optionsBuilder);
            }
        }

        // ---------    DbSets   -----------
        public DbSet<Branch> Branch {get; set; }
          public DbSet<BranchSuppliers> BranchSuppliers { get; set; }
          public  DbSet<Category> Category { get; set; }
          public DbSet<Customer> Customer { get; set; }
          public DbSet<Employee> Employee { get; set; }
          public DbSet<Order> Order { get; set; }
          public DbSet<OrderItems> OrderItems { get; set; }
          public DbSet<Product> Product { get; set; }
          public DbSet<ProductsStocks> ProductsStocks { get; set; }
          public DbSet<ProductsSuppliers> ProductsSuppliers { get; set; }
          public DbSet<Returned> Returned { get; set; }
          public DbSet<ReturnedItems> ReturnedItems { get; set; }
          public DbSet<Stock> Stock { get; set; }
          public DbSet<Supplier> Supplier { get; set; }
          public DbSet<User> User { get; set; }

 




    }
}
