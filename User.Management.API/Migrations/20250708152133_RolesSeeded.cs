using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace User.Management.API.Migrations
{
    /// <inheritdoc />
    public partial class RolesSeeded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9727f3b9-306a-49c9-bb81-d767fa0f7217");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c1fbc709-2fbc-45e1-ae81-f1be7aac81e1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "18c975f2-8fc8-4c2b-bbc8-0d90ae792a9e", "2", "User", "User" },
                    { "781a38c4-b8b0-465b-9304-a631e3eb4e64", "1", "Admin", "Admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18c975f2-8fc8-4c2b-bbc8-0d90ae792a9e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "781a38c4-b8b0-465b-9304-a631e3eb4e64");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9727f3b9-306a-49c9-bb81-d767fa0f7217", "1", "Admin", "Admin" },
                    { "c1fbc709-2fbc-45e1-ae81-f1be7aac81e1", "2", "User", "User" }
                });
        }
    }
}
