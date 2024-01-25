using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HandlingDb.Migrations
{
    /// <inheritdoc />
    public partial class update_ForginKey_ordertable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customer_record_customer_record_CustomerId",
                table: "customer_record");

            migrationBuilder.DropIndex(
                name: "IX_customer_record_CustomerId",
                table: "customer_record");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "customer_record");

            migrationBuilder.CreateIndex(
                name: "IX_order_record_customer_id",
                table: "order_record",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_order_record_product_id",
                table: "order_record",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_customer_record_product_id",
                table: "customer_record",
                column: "product_id");

            migrationBuilder.AddForeignKey(
                name: "FK_customer_record_product_product_id",
                table: "customer_record",
                column: "product_id",
                principalTable: "product",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_order_record_customer_record_customer_id",
                table: "order_record",
                column: "customer_id",
                principalTable: "customer_record",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_order_record_product_product_id",
                table: "order_record",
                column: "product_id",
                principalTable: "product",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customer_record_product_product_id",
                table: "customer_record");

            migrationBuilder.DropForeignKey(
                name: "FK_order_record_customer_record_customer_id",
                table: "order_record");

            migrationBuilder.DropForeignKey(
                name: "FK_order_record_product_product_id",
                table: "order_record");

            migrationBuilder.DropIndex(
                name: "IX_order_record_customer_id",
                table: "order_record");

            migrationBuilder.DropIndex(
                name: "IX_order_record_product_id",
                table: "order_record");

            migrationBuilder.DropIndex(
                name: "IX_customer_record_product_id",
                table: "customer_record");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "customer_record",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_customer_record_CustomerId",
                table: "customer_record",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_customer_record_customer_record_CustomerId",
                table: "customer_record",
                column: "CustomerId",
                principalTable: "customer_record",
                principalColumn: "id");
        }
    }
}
