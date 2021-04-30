using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCAddressBook.data.migration
{
    public partial class _004AddedCategoryType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "States",
                table: "Contact",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "ContactName",
                table: "Category",
                newName: "Name");

            migrationBuilder.AddColumn<int>(
                name: "CategoryType",
                table: "Contact",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryType",
                table: "Category",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryType",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "CategoryType",
                table: "Category");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Contact",
                newName: "States");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Category",
                newName: "ContactName");
        }
    }
}
