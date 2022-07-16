using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopOnline.Api.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("Sqlserver:Identity", "1,1"),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("Sqlserver:Identity", "1,1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
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
                        .Annotation("Sqlserver:Identity", "1,1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                        .Annotation("Sqlserver:Identity", "1,1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
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
                        .Annotation("Sqlserver:Identity", "1,1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });


            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "UserId" },
                values: new object[,] {
                    { 1, 1 },
                    { 2, 2 },
                });

            migrationBuilder.InsertData(
                table: "PK_ProductCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,] {
                    { 1, "Beauty" },
                    { 2, "Furniture" },
                    { 3, "Electronics" },
                    { 4, "Shoes" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Name", "Description", "ImageURL", "Price", "Qty" },
                values: new object[,] {
                    { 1, 1, "Glossier - Beauty Kit", "A kit provided by Glossier, containing skin care, hair care and makeup products", "/Images/Beauty/Beauty1.png", 100m, 100 },
                    { 2, 1, "Curology - Skin Care Kit", "A kit provided by Curology, containing skin care products", "/Images/Beauty/Beauty2.png", 50m,45 },
                    { 3, 1, "Cocooil - Organic Coconut Oil", "A kit provided by Curology, containing skin care products", "/Images/Beauty/Beauty3.png", 20m,30 },
                    { 4, 1, "Schwarzkopf - Hair Care and Skin Care Kit", "A kit provided by Schwarzkopf, containing skin care and hair care products", "/Images/Beauty/Beauty4.png", 50m,60 },
                    { 5, 1, "Skin Care Kit", "Skin Care Kit, containing skin care and hair care products", "/Images/Beauty/Beauty5.png", 30m,85 },
                    { 6, 3, "Air Pods", "Air Pods - in-ear wireless headphones", "/Images/Electronic/Electronics1.png", 100m,120 },
                    { 7, 3, "On-ear Golden Headphones", "On-ear Golden Headphones - these headphones are not wireless", "/Images/Electronic/Electronics2.png", 40m,200 },
                    { 8, 3, "On-ear Black Headphones", "On-ear Black Headphones - these headphones are not wireless", "/Images/Electronic/Electronics3.png", 40m,300 },
                    { 9, 3, "Sennheiser Digital Camera with Tripod", "Sennheiser Digital Camera - High quality digital camera provided by Sennheiser - includes tripod", "/Images/Electronic/Electronics4.png", 600m,20 },
                    { 10, 3, "Canon Digital Camera", "Canon Digital Camera - High quality digital camera provided by Canon", "/Images/Electronic/Electronics5.png", 500m,15 },
                    { 11, 3, "Nintendo Gameboy", "Gameboy - Provided by Nintendo", "/Images/Electronic/Electronics1.png", 100m,60 },
                    { 12, 2, "Black Leather Office Chair", "Very comfortable black leather office chair", "/Images/Furniture/Furniture1.png", 50m,212 },
                    { 13, 2, "Pink Leather Office Chair", "Very comfortable pink leather office chair", "/Images/Furniture/Furniture2.png", 50m,112 },
                    { 14, 2, "Lounge Chair", "Very comfortable lounge chair", "/Images/Furniture/Furniture3.png", 70m,90 },
                    { 15, 2, "Silver Lounge Chair", "Very comfortable Silver lounge chair", "/Images/Furniture/Furniture4.png", 120m,95 },
                    { 16, 2, "Porcelain Table Lamp", "White and blue Porcelain Table Lamp", "/Images/Furniture/Furniture6.png", 15m,100 },
                    { 17, 2, "Office Table Lamp", "Office Table Lamp", "/Images/Furniture/Furniture7.png", 20m,73 },
                    { 18, 4, "Puma Sneakers", "Comfortable Puma Sneakers in most sizes", "/Images/Shoes/Shoes1.png", 100m,50 },
                    { 19, 4, "Colorful Trainers", "Colorful trainsers - available in most sizes", "/Images/Shoes/Shoes2.png", 150m,60 },
                    { 20, 4, "Blue Nike Trainers", "Blue Nike Trainers - available in most sizes", "/Images/Shoes/Shoes3.png", 200m,70 },
                    { 21, 4, "Colorful Hummel Trainers", "Colorful Hummel Trainers - available in most sizes", "/Images/Shoes/Shoes4.png", 120m,120 },
                    { 22, 4, "Red Nike Trainers", "Red Nike Trainers - available in most sizes", "/Images/Shoes/Shoes5.png", 200m,100 },
                    { 23, 4, "Birkenstock Sandles", "Birkenstock Sandles - available in most sizes", "/Images/Shoes/Shoes6.png", 50m,150 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "UserName" },
                values: new object[,] {
                    { 1, "Bob" },
                    { 2, "Sarah" }
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
