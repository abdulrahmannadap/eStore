using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedBatchTableWithOneRecord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Batches",
                columns: new[] { "BatchNumber", "BatchDetails", "Product_Id" },
                values: new object[] { 10200, "Some details goes here", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Batches",
                keyColumn: "BatchNumber",
                keyValue: 10200);
        }
    }
}
