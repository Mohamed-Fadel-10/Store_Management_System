using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Store_System.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branch",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManagerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainMoneyStock = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branch", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Stock",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockManager = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContractDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    branch_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Employee_Branch_branch_ID",
                        column: x => x.branch_ID,
                        principalTable: "Branch",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    Branch_Id = table.Column<int>(type: "int", nullable: true),
                    MoneyStockName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoneyStockAmount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                    table.ForeignKey(
                        name: "FK_User_Branch_Branch_Id",
                        column: x => x.Branch_Id,
                        principalTable: "Branch",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Barcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SellingPrice = table.Column<double>(type: "float", nullable: false),
                    Cost = table.Column<double>(type: "float", nullable: false),
                    Discount = table.Column<double>(type: "float", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Production_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Expiry_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StockAmount = table.Column<int>(type: "int", nullable: false),
                    Category_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Product_Category_Category_id",
                        column: x => x.Category_id,
                        principalTable: "Category",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BranchSuppliers",
                columns: table => new
                {
                    Branch_Id = table.Column<int>(type: "int", nullable: false),
                    Supplier_Id = table.Column<int>(type: "int", nullable: false),
                    BranchID = table.Column<int>(type: "int", nullable: true),
                    SupplierID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchSuppliers", x => new { x.Supplier_Id, x.Branch_Id });
                    table.ForeignKey(
                        name: "FK_BranchSuppliers_Branch_Branch_Id",
                        column: x => x.Branch_Id,
                        principalTable: "Branch",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_BranchSuppliers_Branch_BranchID",
                        column: x => x.BranchID,
                        principalTable: "Branch",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_BranchSuppliers_Supplier_Supplier_Id",
                        column: x => x.Supplier_Id,
                        principalTable: "Supplier",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_BranchSuppliers_Supplier_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Supplier",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ShippedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsSale = table.Column<bool>(type: "bit", nullable: false),
                    user_id = table.Column<int>(type: "int", nullable: true),
                    Customer_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Order_Customer_Customer_Id",
                        column: x => x.Customer_Id,
                        principalTable: "Customer",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Order_User_user_id",
                        column: x => x.user_id,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ProductsStocks",
                columns: table => new
                {
                    Product_Id = table.Column<int>(type: "int", nullable: false),
                    Stock_Id = table.Column<int>(type: "int", nullable: false),
                    QuantityInStock = table.Column<int>(type: "int", nullable: false),
                    MinQuantity = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: true),
                    StockID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsStocks", x => new { x.Stock_Id, x.Product_Id });
                    table.ForeignKey(
                        name: "FK_ProductsStocks_Product_Product_Id",
                        column: x => x.Product_Id,
                        principalTable: "Product",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ProductsStocks_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ProductsStocks_Stock_Stock_Id",
                        column: x => x.Stock_Id,
                        principalTable: "Stock",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ProductsStocks_Stock_StockID",
                        column: x => x.StockID,
                        principalTable: "Stock",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ProductsSuppliers",
                columns: table => new
                {
                    product_Id = table.Column<int>(type: "int", nullable: false),
                    Supplier_Id = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: true),
                    SupplierID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsSuppliers", x => new { x.product_Id, x.Supplier_Id });
                    table.ForeignKey(
                        name: "FK_ProductsSuppliers_Product_product_Id",
                        column: x => x.product_Id,
                        principalTable: "Product",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ProductsSuppliers_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ProductsSuppliers_Supplier_Supplier_Id",
                        column: x => x.Supplier_Id,
                        principalTable: "Supplier",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ProductsSuppliers_Supplier_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Supplier",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Order_Id = table.Column<int>(type: "int", nullable: false),
                    ItemID = table.Column<int>(type: "int", nullable: false),
                    product_Id = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<double>(type: "float", nullable: false),
                    Discount = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => new { x.Order_Id, x.ItemID });
                    table.ForeignKey(
                        name: "FK_OrderItems_Order_Order_Id",
                        column: x => x.Order_Id,
                        principalTable: "Order",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Product_product_Id",
                        column: x => x.product_Id,
                        principalTable: "Product",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Returned",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Returned", x => x.id);
                    table.ForeignKey(
                        name: "FK_Returned_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ReturnedItems",
                columns: table => new
                {
                    Returned_Id = table.Column<int>(type: "int", nullable: false),
                    Product_Id = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderID = table.Column<int>(type: "int", nullable: true),
                    ReturnedQuantity = table.Column<int>(type: "int", nullable: true),
                    ProductID = table.Column<int>(type: "int", nullable: true),
                    Returnedid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnedItems", x => new { x.Returned_Id, x.Product_Id });
                    table.ForeignKey(
                        name: "FK_ReturnedItems_Product_Product_Id",
                        column: x => x.Product_Id,
                        principalTable: "Product",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ReturnedItems_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ReturnedItems_Returned_Returned_Id",
                        column: x => x.Returned_Id,
                        principalTable: "Returned",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_ReturnedItems_Returned_Returnedid",
                        column: x => x.Returnedid,
                        principalTable: "Returned",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BranchSuppliers_Branch_Id",
                table: "BranchSuppliers",
                column: "Branch_Id");

            migrationBuilder.CreateIndex(
                name: "IX_BranchSuppliers_BranchID",
                table: "BranchSuppliers",
                column: "BranchID");

            migrationBuilder.CreateIndex(
                name: "IX_BranchSuppliers_SupplierID",
                table: "BranchSuppliers",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_branch_ID",
                table: "Employee",
                column: "branch_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Customer_Id",
                table: "Order",
                column: "Customer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Order_user_id",
                table: "Order",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_product_Id",
                table: "OrderItems",
                column: "product_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Category_id",
                table: "Product",
                column: "Category_id");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsStocks_Product_Id",
                table: "ProductsStocks",
                column: "Product_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsStocks_ProductID",
                table: "ProductsStocks",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsStocks_StockID",
                table: "ProductsStocks",
                column: "StockID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsSuppliers_ProductID",
                table: "ProductsSuppliers",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsSuppliers_Supplier_Id",
                table: "ProductsSuppliers",
                column: "Supplier_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsSuppliers_SupplierID",
                table: "ProductsSuppliers",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_Returned_OrderID",
                table: "Returned",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnedItems_Product_Id",
                table: "ReturnedItems",
                column: "Product_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnedItems_ProductID",
                table: "ReturnedItems",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnedItems_Returnedid",
                table: "ReturnedItems",
                column: "Returnedid");

            migrationBuilder.CreateIndex(
                name: "IX_User_Branch_Id",
                table: "User",
                column: "Branch_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BranchSuppliers");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "ProductsStocks");

            migrationBuilder.DropTable(
                name: "ProductsSuppliers");

            migrationBuilder.DropTable(
                name: "ReturnedItems");

            migrationBuilder.DropTable(
                name: "Stock");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Returned");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Branch");
        }
    }
}
