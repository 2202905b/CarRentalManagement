using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class addmigrationadddefaultdataanduser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "7400b835-3e8c-46e8-8adc-b8d956132e67", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEJHu5O0v83J2DHd19grhCB3TLuE4Hw6OQIi51ZxKYa+9+q8uZHOv6TZOdtyVYwrIYg==", null, false, "fdb53a5f-e8ce-4e89-a7fd-1d420cb2ff7c", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 15, 13, 40, 0, DateTimeKind.Local).AddTicks(8034), new DateTime(2023, 11, 23, 15, 13, 40, 0, DateTimeKind.Local).AddTicks(8059) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 15, 13, 40, 0, DateTimeKind.Local).AddTicks(8069), new DateTime(2023, 11, 23, 15, 13, 40, 0, DateTimeKind.Local).AddTicks(8071) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 15, 13, 40, 0, DateTimeKind.Local).AddTicks(8853), new DateTime(2023, 11, 23, 15, 13, 40, 0, DateTimeKind.Local).AddTicks(8856) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 15, 13, 40, 0, DateTimeKind.Local).AddTicks(8860), new DateTime(2023, 11, 23, 15, 13, 40, 0, DateTimeKind.Local).AddTicks(8861) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 15, 13, 40, 0, DateTimeKind.Local).AddTicks(9331), new DateTime(2023, 11, 23, 15, 13, 40, 0, DateTimeKind.Local).AddTicks(9333) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 15, 13, 40, 0, DateTimeKind.Local).AddTicks(9339), new DateTime(2023, 11, 23, 15, 13, 40, 0, DateTimeKind.Local).AddTicks(9341) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 15, 13, 40, 0, DateTimeKind.Local).AddTicks(9344), new DateTime(2023, 11, 23, 15, 13, 40, 0, DateTimeKind.Local).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 15, 13, 40, 0, DateTimeKind.Local).AddTicks(9349), new DateTime(2023, 11, 23, 15, 13, 40, 0, DateTimeKind.Local).AddTicks(9350) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 15, 4, 12, 579, DateTimeKind.Local).AddTicks(1806), new DateTime(2023, 11, 23, 15, 4, 12, 579, DateTimeKind.Local).AddTicks(1823) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 15, 4, 12, 579, DateTimeKind.Local).AddTicks(1826), new DateTime(2023, 11, 23, 15, 4, 12, 579, DateTimeKind.Local).AddTicks(1826) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 15, 4, 12, 579, DateTimeKind.Local).AddTicks(2247), new DateTime(2023, 11, 23, 15, 4, 12, 579, DateTimeKind.Local).AddTicks(2248) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 15, 4, 12, 579, DateTimeKind.Local).AddTicks(2250), new DateTime(2023, 11, 23, 15, 4, 12, 579, DateTimeKind.Local).AddTicks(2250) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 15, 4, 12, 579, DateTimeKind.Local).AddTicks(2471), new DateTime(2023, 11, 23, 15, 4, 12, 579, DateTimeKind.Local).AddTicks(2472) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 15, 4, 12, 579, DateTimeKind.Local).AddTicks(2474), new DateTime(2023, 11, 23, 15, 4, 12, 579, DateTimeKind.Local).AddTicks(2474) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 15, 4, 12, 579, DateTimeKind.Local).AddTicks(2476), new DateTime(2023, 11, 23, 15, 4, 12, 579, DateTimeKind.Local).AddTicks(2476) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 23, 15, 4, 12, 579, DateTimeKind.Local).AddTicks(2477), new DateTime(2023, 11, 23, 15, 4, 12, 579, DateTimeKind.Local).AddTicks(2478) });
        }
    }
}
