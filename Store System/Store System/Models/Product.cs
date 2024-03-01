﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_System.Models
{
    public enum Size
    {
        S,
        M,
        L,
        XL,
        XXL,
        XXXL,
        Custom
    }

    internal class Product
    {
        [Key]
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double SellingPrice { get; set; }
        public double Cost { get; set;}
        public double Discount { get; set;}
        public Size Size { get; set; }
        public string? Color { get; set; }
        public DateTime Production_Date { get; set; }
        public DateTime Expiry_date { get; set; }
        public int StockAmount { get; set; }
        public Category Category { get; set; }
        [ForeignKey("Category")]
        public int Category_id { get; set; }
        public List<OrderItems> OrderItems { get; set; }
        public List<ProductsSuppliers> ProductsSuppliers  { get; set; }
        public List<ProductsStocks> ProductsStocks { get; set; }
        public List<ReturnedItems> ReturnedItems { get; set; }


    }
}
