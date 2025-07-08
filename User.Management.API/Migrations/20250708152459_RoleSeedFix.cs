using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace User.Management.API.Migrations
{
    /// <inheritdoc />
    public partial class RoleSeedFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "4dcb3d50-7165-4f5e-b96f-2e60a12ad7b0", "2", "User", "USER" },
                    { "e6b1c40f-8a2e-4c3c-9fc0-1fa479e4707a", "1", "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4dcb3d50-7165-4f5e-b96f-2e60a12ad7b0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e6b1c40f-8a2e-4c3c-9fc0-1fa479e4707a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "18c975f2-8fc8-4c2b-bbc8-0d90ae792a9e", "2", "User", "User" },
                    { "781a38c4-b8b0-465b-9304-a631e3eb4e64", "1", "Admin", "Admin" }
                });
        }
    }
}
