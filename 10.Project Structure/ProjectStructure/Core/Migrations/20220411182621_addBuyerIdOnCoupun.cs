using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    public partial class addBuyerIdOnCoupun : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coupons_Buyers_BuyerId",
                table: "Coupons");

            migrationBuilder.AlterColumn<int>(
                name: "BuyerId",
                table: "Coupons",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Coupons_Buyers_BuyerId",
                table: "Coupons",
                column: "BuyerId",
                principalTable: "Buyers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coupons_Buyers_BuyerId",
                table: "Coupons");

            migrationBuilder.AlterColumn<int>(
                name: "BuyerId",
                table: "Coupons",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Coupons_Buyers_BuyerId",
                table: "Coupons",
                column: "BuyerId",
                principalTable: "Buyers",
                principalColumn: "Id");
        }
    }
}
