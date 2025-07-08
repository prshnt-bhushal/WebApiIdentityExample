using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPIAuthExample.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserRoles_RolesRoleId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_companies_CompanyKiranaId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_CompanyKiranaId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_RolesRoleId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CompanyKiranaId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RolesRoleId",
                table: "Users");

            migrationBuilder.CreateIndex(
                name: "IX_Users_KiranaId",
                table: "Users",
                column: "KiranaId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserRoles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "UserRoles",
                principalColumn: "RoleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_companies_KiranaId",
                table: "Users",
                column: "KiranaId",
                principalTable: "companies",
                principalColumn: "KiranaId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserRoles_RoleId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_companies_KiranaId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_KiranaId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_RoleId",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "CompanyKiranaId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RolesRoleId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Users_CompanyKiranaId",
                table: "Users",
                column: "CompanyKiranaId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RolesRoleId",
                table: "Users",
                column: "RolesRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserRoles_RolesRoleId",
                table: "Users",
                column: "RolesRoleId",
                principalTable: "UserRoles",
                principalColumn: "RoleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_companies_CompanyKiranaId",
                table: "Users",
                column: "CompanyKiranaId",
                principalTable: "companies",
                principalColumn: "KiranaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
