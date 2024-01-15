using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentEnrollmentApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4a6db99c-6c4f-4799-a3f5-740d9b72ee43", null, "Administrator", "ADMINISTRATOR" },
                    { "da8df7b5-1411-4403-94b2-4c4bfcd89a88", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Credits", "ModifiedBy", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 1, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minimal API Development" },
                    { 2, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ultimate API Development" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a6db99c-6c4f-4799-a3f5-740d9b72ee43");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da8df7b5-1411-4403-94b2-4c4bfcd89a88");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
