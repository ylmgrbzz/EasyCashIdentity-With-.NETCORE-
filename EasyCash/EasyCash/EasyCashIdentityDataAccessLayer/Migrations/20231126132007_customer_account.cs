using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyCashIdentityDataAccessLayer.Migrations
{
    public partial class customer_account : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "appUserId",
                table: "CustomerAccounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAccounts_appUserId",
                table: "CustomerAccounts",
                column: "appUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAccounts_AspNetUsers_appUserId",
                table: "CustomerAccounts",
                column: "appUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAccounts_AspNetUsers_appUserId",
                table: "CustomerAccounts");

            migrationBuilder.DropIndex(
                name: "IX_CustomerAccounts_appUserId",
                table: "CustomerAccounts");

            migrationBuilder.DropColumn(
                name: "appUserId",
                table: "CustomerAccounts");
        }
    }
}
