using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleAppLIAEcommerce.Migrations
{
    public partial class AddedBooleanToAddressTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsBillingAddressTheSame",
                table: "Addresses",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "IsBillingAddressTheSame",
                table: "Addresses");
        }
    }
}
