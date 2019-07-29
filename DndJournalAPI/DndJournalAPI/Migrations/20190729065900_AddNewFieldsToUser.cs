using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DndJournalAPI.Migrations
{
    public partial class AddNewFieldsToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SignUpDate",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SignUpDate",
                table: "Users");
        }
    }
}
