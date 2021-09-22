using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleAppLIAEcommerce.Migrations
{
    public partial class initi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    SubCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.SubCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountedPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SKU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UPC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MyProperty = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    MinimumQuantity = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Length = table.Column<double>(type: "float", nullable: false),
                    Width = table.Column<double>(type: "float", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    MainImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RewardPoints = table.Column<int>(type: "int", nullable: false),
                    AddDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SubCategoryId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "SubCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pictures",
                columns: table => new
                {
                    PicId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PicName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pictures", x => x.PicId);
                    table.ForeignKey(
                        name: "FK_Pictures_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "SubCategoryId", "SubCategoryName" },
                values: new object[] { 1, "Mejeri" });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "SubCategoryId", "SubCategoryName" },
                values: new object[] { 2, "Ägg" });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "SubCategoryId", "SubCategoryName" },
                values: new object[] { 3, "Pasta & Noodles" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "AddDateTime", "CategoryId", "Description", "DiscountedPrice", "Height", "Length", "MainImageUrl", "MinimumQuantity", "Model", "MyProperty", "Name", "Price", "Quantity", "RewardPoints", "SKU", "ShortDescription", "Status", "SubCategoryId", "UPC", "Weight", "Width" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Land: Tyskland", 7.50m, 0.0, 0.0, null, 0, null, 0, "Smör", 10.90m, 0, 0, null, "Ekologisk", true, 1, null, 0.0, 0.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "AddDateTime", "CategoryId", "Description", "DiscountedPrice", "Height", "Length", "MainImageUrl", "MinimumQuantity", "Model", "MyProperty", "Name", "Price", "Quantity", "RewardPoints", "SKU", "ShortDescription", "Status", "SubCategoryId", "UPC", "Weight", "Width" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Land: Sverige", 19.90m, 0.0, 0.0, null, 0, null, 0, "Ägg", 25.90m, 0, 0, null, "Frigående", true, 2, null, 0.0, 0.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "AddDateTime", "CategoryId", "Description", "DiscountedPrice", "Height", "Length", "MainImageUrl", "MinimumQuantity", "Model", "MyProperty", "Name", "Price", "Quantity", "RewardPoints", "SKU", "ShortDescription", "Status", "SubCategoryId", "UPC", "Weight", "Width" },
                values: new object[] { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Land: Italien", 4.50m, 0.0, 0.0, null, 0, null, 0, "Pasta", 6.50m, 0, 0, null, "Fussilli", false, 3, null, 0.0, 0.0 });

            migrationBuilder.InsertData(
                table: "Pictures",
                columns: new[] { "PicId", "PicName", "ProductId" },
                values: new object[] { 2, "url 2...", 2 });

            migrationBuilder.InsertData(
                table: "Pictures",
                columns: new[] { "PicId", "PicName", "ProductId" },
                values: new object[] { 1, "url 1...", 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Pictures_ProductId",
                table: "Pictures",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SubCategoryId",
                table: "Products",
                column: "SubCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pictures");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "SubCategories");
        }
    }
}
