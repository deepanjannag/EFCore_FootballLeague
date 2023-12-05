using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore.Data.Migrations
{
    /// <inheritdoc />
    public partial class ReSeededTeams : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Name" },
                values: new object[] { new DateTime(2023, 12, 5, 2, 25, 58, 753, DateTimeKind.Unspecified).AddTicks(3872), "Tivoli Gardens F.C." });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Name" },
                values: new object[] { new DateTime(2023, 12, 5, 2, 25, 58, 753, DateTimeKind.Unspecified).AddTicks(3880), "Waterhouse F.C." });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "Name" },
                values: new object[] { new DateTime(2023, 12, 5, 2, 25, 58, 753, DateTimeKind.Unspecified).AddTicks(3881), "Humble Lions F.C." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Name" },
                values: new object[] { new DateTime(2023, 12, 5, 2, 17, 33, 372, DateTimeKind.Unspecified).AddTicks(3179), "Mohan Bagan" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Name" },
                values: new object[] { new DateTime(2023, 12, 5, 2, 17, 33, 372, DateTimeKind.Unspecified).AddTicks(3185), "East Bengal" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "Name" },
                values: new object[] { new DateTime(2023, 12, 5, 2, 17, 33, 372, DateTimeKind.Unspecified).AddTicks(3187), "Inter Milan" });
        }
    }
}
