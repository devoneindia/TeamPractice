using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HandlingDb.Migrations
{
    /// <inheritdoc />
    public partial class _20240124_AddingForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "customer_id",
                table: "order_record",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "customer_id",
                table: "order_record");
        }
    }
}
