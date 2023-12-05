using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCore.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeededTeams : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "DateCreated", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 5, 2, 17, 33, 372, DateTimeKind.Unspecified).AddTicks(3179), "Mohan Bagan" },
                    { 2, new DateTime(2023, 12, 5, 2, 17, 33, 372, DateTimeKind.Unspecified).AddTicks(3185), "East Bengal" },
                    { 3, new DateTime(2023, 12, 5, 2, 17, 33, 372, DateTimeKind.Unspecified).AddTicks(3187), "Inter Milan" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
