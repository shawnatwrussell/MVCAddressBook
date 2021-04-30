using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCAddressBook.data.migration
{
    public partial class _005RemovedCategoryID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryType",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "ContactId",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Category");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryType",
                table: "Contact",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ContactId",
                table: "Contact",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Category",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
