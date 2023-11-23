using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 23, 15, 4, 12, 579, DateTimeKind.Local).AddTicks(1806), new DateTime(2023, 11, 23, 15, 4, 12, 579, DateTimeKind.Local).AddTicks(1823), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 23, 15, 4, 12, 579, DateTimeKind.Local).AddTicks(1826), new DateTime(2023, 11, 23, 15, 4, 12, 579, DateTimeKind.Local).AddTicks(1826), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 23, 15, 4, 12, 579, DateTimeKind.Local).AddTicks(2247), new DateTime(2023, 11, 23, 15, 4, 12, 579, DateTimeKind.Local).AddTicks(2248), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 23, 15, 4, 12, 579, DateTimeKind.Local).AddTicks(2250), new DateTime(2023, 11, 23, 15, 4, 12, 579, DateTimeKind.Local).AddTicks(2250), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 23, 15, 4, 12, 579, DateTimeKind.Local).AddTicks(2471), new DateTime(2023, 11, 23, 15, 4, 12, 579, DateTimeKind.Local).AddTicks(2472), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 23, 15, 4, 12, 579, DateTimeKind.Local).AddTicks(2474), new DateTime(2023, 11, 23, 15, 4, 12, 579, DateTimeKind.Local).AddTicks(2474), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 23, 15, 4, 12, 579, DateTimeKind.Local).AddTicks(2476), new DateTime(2023, 11, 23, 15, 4, 12, 579, DateTimeKind.Local).AddTicks(2476), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 23, 15, 4, 12, 579, DateTimeKind.Local).AddTicks(2477), new DateTime(2023, 11, 23, 15, 4, 12, 579, DateTimeKind.Local).AddTicks(2478), "Rav4", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
