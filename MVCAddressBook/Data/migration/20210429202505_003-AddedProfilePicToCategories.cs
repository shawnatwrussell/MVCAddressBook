using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCAddressBook.data.migration
{
    public partial class _003AddedProfilePicToCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContentType",
                table: "Category",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Poster",
                table: "Category",
                type: "bytea",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContentType",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "Poster",
                table: "Category");
        }
    }
}
