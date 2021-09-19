using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleAppLIAEcommerce.Migrations
{
    public partial class ProductCategoryadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ProductId", "CategoryId" },
                values: new object[] { 2, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "ProductId",
                keyValue: 2);
        }
    }
}
