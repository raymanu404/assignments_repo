using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    public partial class updateCouponsAndDeleteOnCascading : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coupons_Buyers_BuyerId",
                table: "Coupons");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Coupons_Buyers_BuyerId",
                table: "Coupons",
                column: "BuyerId",
                principalTable: "Buyers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
