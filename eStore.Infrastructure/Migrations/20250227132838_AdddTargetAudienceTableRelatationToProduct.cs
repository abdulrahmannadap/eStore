using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AdddTargetAudienceTableRelatationToProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Product_Id",
                table: "TargetAudiences",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TargetAudiences_Product_Id",
                table: "TargetAudiences",
                column: "Product_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TargetAudiences_Products_Product_Id",
                table: "TargetAudiences",
                column: "Product_Id",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TargetAudiences_Products_Product_Id",
                table: "TargetAudiences");

            migrationBuilder.DropIndex(
                name: "IX_TargetAudiences_Product_Id",
                table: "TargetAudiences");

            migrationBuilder.DropColumn(
                name: "Product_Id",
                table: "TargetAudiences");
        }
    }
}
