using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedEmployeesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "DateOfBirth", "Dept", "FirstName", "IsActive", "LastName", "ModifiedDate", "PositionId" },
                values: new object[] { 1, "Jordan Misja", new DateTime(2003, 1, 31, 19, 59, 1, 746, DateTimeKind.Local).AddTicks(7899), "", "Erjeta", true, "Kamolli", new DateTime(2023, 1, 31, 19, 59, 1, 746, DateTimeKind.Local).AddTicks(7935), 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
