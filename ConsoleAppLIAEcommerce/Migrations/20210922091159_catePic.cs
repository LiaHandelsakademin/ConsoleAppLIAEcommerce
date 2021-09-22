using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleAppLIAEcommerce.Migrations
{
    public partial class catePic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Pictures",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PicName",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pictures_CategoryId",
                table: "Pictures",
                column: "CategoryId",
                unique: true,
                filter: "[CategoryId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Pictures_Categories_CategoryId",
                table: "Pictures",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pictures_Categories_CategoryId",
                table: "Pictures");

            migrationBuilder.DropIndex(
                name: "IX_Pictures_CategoryId",
                table: "Pictures");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Pictures");

            migrationBuilder.DropColumn(
                name: "PicName",
                table: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
