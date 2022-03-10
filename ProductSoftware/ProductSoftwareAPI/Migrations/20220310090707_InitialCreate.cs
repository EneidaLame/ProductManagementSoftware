using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductSoftwareAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Monitors" },
                    { 2, "Desktops" },
                    { 3, "Laptops" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price", "Qty" },
                values: new object[,]
                {
                    { 1, 1, "Acer Monitors", "/Images/Monitors/1.jpg", "Monitor", 200m, 10 },
                    { 2, 1, "Omen Monitors", "/Images/Monitors/2.png", "Monitor", 400m, 45 },
                    { 3, 1, "Gaiming Monitor", "/Images/Monitors/3.jpg", "Monitor", 200m, 30 },
                    { 4, 1, "GamingMonitors", "/Images/Monitors/4.png", "Monitor", 700m, 30 },
                    { 5, 1, "Curved Monitors", "/Images/Monitors/5.jpg", "Monitor", 500m, 100 },
                    { 6, 1, "Monitors", "/Images/Monitors/6.jpg", "Monitor", 400m, 11 },
                    { 7, 2, "Desktop", "/Images/Desktop/1.jpg", "Desktop", 1000m, 120 },
                    { 8, 2, "Desktop", "/Images/Desktop/2.jpeg", "Desktop", 400m, 200 },
                    { 9, 2, "Desktop", "/Images/Desktop/3.jpg", "Desktop", 600m, 300 },
                    { 10, 2, "Desktop", "/Images/Desktop/4.jpeg", "Desktop", 800m, 30 },
                    { 11, 2, "Desktop", "/Images/Desktop/5.jpg", "Desktop", 800m, 90 },
                    { 12, 2, "Desktop", "/Images/Desktop/6.jpg", "Desktop", 1000m, 200 },
                    { 13, 3, "Laptop", "/Images/Laptops/1.jpeg", "Laptop", 500m, 212 },
                    { 14, 3, "Laptop", "/Images/Laptops/2.jpg", "Laptop", 760m, 112 },
                    { 19, 3, "Laptop", "/Images/Laptops/3.jpeg", "Laptop", 700m, 90 },
                    { 20, 3, "Laptop", "/Images/Laptops/4.jpg", "Laptop", 900m, 65 },
                    { 21, 3, "Laptop", "/Images/Laptops/5.jpeg", "Laptop", 400m, 22 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "UserName" },
                values: new object[,]
                {
                    { 1, "Maria" },
                    { 2, "Xristina" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
