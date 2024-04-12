using Store_System.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class OrderItems
{
    [Key]
    public int ID { get; set; }
    public int Order_Id { get; set; }
    public virtual Product Product { get; set; }
    public virtual Order Order { get; set; }

    [ForeignKey("Product")]
    public int product_Id { get; set; } 

    public double TotalPrice { get; set; }
    public double Discount { get; set; }
    public int Quantity { get; set; }
    public string? Size { get; set; }
    public string? Color { get; set; }
    public string? Description { get; set; }
}
