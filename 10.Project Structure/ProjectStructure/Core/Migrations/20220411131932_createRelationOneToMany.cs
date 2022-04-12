using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    public partial class createRelationOneToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coupoun_Buyers_BuyerId",
                table: "Coupoun");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Coupoun",
                table: "Coupoun");

            migrationBuilder.RenameTable(
                name: "Coupoun",
                newName: "Coupons");

            migrationBuilder.RenameIndex(
                name: "IX_Coupoun_BuyerId",
                table: "Coupons",
                newName: "IX_Coupons_BuyerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Coupons",
                table: "Coupons",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Coupons_Buyers_BuyerId",
                table: "Coupons",
                column: "BuyerId",
                principalTable: "Buyers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coupons_Buyers_BuyerId",
                table: "Coupons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Coupons",
                table: "Coupons");

            migrationBuilder.RenameTable(
                name: "Coupons",
                newName: "Coupoun");

            migrationBuilder.RenameIndex(
                name: "IX_Coupons_BuyerId",
                table: "Coupoun",
                newName: "IX_Coupoun_BuyerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Coupoun",
                table: "Coupoun",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Coupoun_Buyers_BuyerId",
                table: "Coupoun",
                column: "BuyerId",
                principalTable: "Buyers",
                principalColumn: "Id");
        }
    }
}
