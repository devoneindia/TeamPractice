using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HandlingDb.Migrations
{
    /// <inheritdoc />
    public partial class _20240124_RemoveCustomerOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerCustomerOrder");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerCustomerOrder",
                columns: table => new
                {
                    CustomersId = table.Column<int>(type: "integer", nullable: false),
                    OrdersOrderId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerCustomerOrder", x => new { x.CustomersId, x.OrdersOrderId });
                    table.ForeignKey(
                        name: "FK_CustomerCustomerOrder_customer_record_CustomersId",
                        column: x => x.CustomersId,
                        principalTable: "customer_record",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerCustomerOrder_order_record_OrdersOrderId",
                        column: x => x.OrdersOrderId,
                        principalTable: "order_record",
                        principalColumn: "order_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerCustomerOrder_OrdersOrderId",
                table: "CustomerCustomerOrder",
                column: "OrdersOrderId");
        }
    }
}
