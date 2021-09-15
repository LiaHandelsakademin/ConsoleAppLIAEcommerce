using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleAppLIAEcommerce.Migrations
{
    public partial class SeedTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "DiscountedPrice", "Height", "Length", "MainImageUrl", "MinimumQuantity", "Model", "MyProperty", "Name", "Price", "Quantity", "RewardPoints", "SKU", "ShortDescription", "Status", "UPC", "Weight", "Width" },
                values: new object[] { 3, "Land: Sverige", 19.90m, 0.0, 0.0, null, 0, null, 0, "Ägg", 25.90m, 0, 0, null, "Frigående", true, null, 0.0, 0.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "DiscountedPrice", "Height", "Length", "MainImageUrl", "MinimumQuantity", "Model", "MyProperty", "Name", "Price", "Quantity", "RewardPoints", "SKU", "ShortDescription", "Status", "UPC", "Weight", "Width" },
                values: new object[] { 4, "Land: Tyskland", 7.50m, 0.0, 0.0, null, 0, null, 0, "Smör", 10.90m, 0, 0, null, "Ekologisk", true, null, 0.0, 0.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "DiscountedPrice", "Height", "Length", "MainImageUrl", "MinimumQuantity", "Model", "MyProperty", "Name", "Price", "Quantity", "RewardPoints", "SKU", "ShortDescription", "Status", "UPC", "Weight", "Width" },
                values: new object[] { 5, "Land: Italien", 4.50m, 0.0, 0.0, null, 0, null, 0, "Pasta", 6.50m, 0, 0, null, "Fussilli", false, null, 0.0, 0.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
