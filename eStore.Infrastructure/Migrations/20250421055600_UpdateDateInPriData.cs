using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDateInPriData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "PublishDate", "Rating" },
                values: new object[] { new DateOnly(2025, 4, 16), 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "PublishDate", "Rating" },
                values: new object[] { new DateOnly(2025, 4, 17), 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "PublishDate", "Rating" },
                values: new object[] { new DateOnly(1, 1, 1), 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "PublishDate", "Rating" },
                values: new object[] { new DateOnly(2025, 4, 19), 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "PublishDate", "Rating" },
                values: new object[] { new DateOnly(2025, 4, 20), 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "PublishDate", "Rating" },
                values: new object[] { new DateOnly(2025, 4, 16), 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "PublishDate", "Rating" },
                values: new object[] { new DateOnly(2025, 4, 19), 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "PublishDate", "Rating" },
                values: new object[] { new DateOnly(2025, 4, 15), 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "PublishDate", "Rating" },
                values: new object[] { new DateOnly(2025, 4, 17), 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "PublishDate", "Rating" },
                values: new object[] { new DateOnly(2025, 4, 20), 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "PublishDate", "Rating" },
                values: new object[] { new DateOnly(2025, 4, 19), 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "PublishDate", "Rating" },
                values: new object[] { new DateOnly(2025, 4, 17), 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "PublishDate", "Rating" },
                values: new object[] { new DateOnly(2025, 4, 16), 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "PublishDate", "Rating" },
                values: new object[] { new DateOnly(2025, 4, 16), 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "PublishDate", "Rating" },
                values: new object[] { new DateOnly(2025, 4, 15), 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "PublishDate", "Rating" },
                values: new object[] { new DateOnly(2025, 4, 21), 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "PublishDate", "Rating" },
                values: new object[] { new DateOnly(2025, 4, 18), 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "PublishDate", "Rating" },
                values: new object[] { new DateOnly(2025, 4, 16), 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 501,
                column: "PublishDate",
                value: new DateOnly(2025, 4, 19));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 502,
                column: "PublishDate",
                value: new DateOnly(2025, 4, 21));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 503,
                column: "PublishDate",
                value: new DateOnly(2025, 4, 18));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 504,
                column: "PublishDate",
                value: new DateOnly(2025, 4, 19));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 505,
                column: "PublishDate",
                value: new DateOnly(2025, 4, 19));

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ProductId",
                table: "Orders",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Products_ProductId",
                table: "Orders",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Products_ProductId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ProductId",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "PublishDate", "Rating" },
                values: new object[] { new DateOnly(2025, 2, 27), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "PublishDate", "Rating" },
                values: new object[] { new DateOnly(2025, 2, 27), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "PublishDate", "Rating" },
                values: new object[] { new DateOnly(2025, 2, 25), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "PublishDate", "Rating" },
                values: new object[] { new DateOnly(2025, 2, 27), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "PublishDate", "Rating" },
                values: new object[] { new DateOnly(2025, 2, 28), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "PublishDate", "Rating" },
                values: new object[] { new DateOnly(2025, 3, 2), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "PublishDate", "Rating" },
                values: new object[] { new DateOnly(2025, 2, 27), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "PublishDate", "Rating" },
                values: new object[] { new DateOnly(2025, 2, 25), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "PublishDate", "Rating" },
                values: new object[] { new DateOnly(2025, 2, 26), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "PublishDate", "Rating" },
                values: new object[] { new DateOnly(2025, 2, 26), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "PublishDate", "Rating" },
                values: new object[] { new DateOnly(2025, 2, 26), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "PublishDate", "Rating" },
                values: new object[] { new DateOnly(2025, 2, 27), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "PublishDate", "Rating" },
                values: new object[] { new DateOnly(2025, 2, 27), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "PublishDate", "Rating" },
                values: new object[] { new DateOnly(2025, 2, 28), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "PublishDate", "Rating" },
                values: new object[] { new DateOnly(2025, 3, 2), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "PublishDate", "Rating" },
                values: new object[] { new DateOnly(2025, 3, 1), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "PublishDate", "Rating" },
                values: new object[] { new DateOnly(2025, 3, 2), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "PublishDate", "Rating" },
                values: new object[] { new DateOnly(2025, 2, 28), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 501,
                column: "PublishDate",
                value: new DateOnly(2025, 3, 2));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 502,
                column: "PublishDate",
                value: new DateOnly(2025, 2, 27));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 503,
                column: "PublishDate",
                value: new DateOnly(2025, 2, 25));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 504,
                column: "PublishDate",
                value: new DateOnly(2025, 2, 28));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 505,
                column: "PublishDate",
                value: new DateOnly(2025, 2, 25));
        }
    }
}
