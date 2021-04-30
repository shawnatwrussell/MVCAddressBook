using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCAddressBook.data.migration
{
    public partial class _002UpdatedModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Category_CategoryId",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "ContactId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "ContentType",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "Poster",
                table: "Category");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Category",
                newName: "ContactName");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Contact",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContentType",
                table: "Contact",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Poster",
                table: "Contact",
                type: "bytea",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Category_CategoryId",
                table: "Contact",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Category_CategoryId",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "ContentType",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "Poster",
                table: "Contact");

            migrationBuilder.RenameColumn(
                name: "ContactName",
                table: "Category",
                newName: "LastName");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Contact",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "ContactId",
                table: "Category",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ContentType",
                table: "Category",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Category",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Poster",
                table: "Category",
                type: "bytea",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Category_CategoryId",
                table: "Contact",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
