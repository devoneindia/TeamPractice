using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HandlingDb.Migrations
{
    /// <inheritdoc />
    public partial class _20240123_renameCd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer_Record",
                table: "Customer_Record");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CricketerDeatils",
                table: "CricketerDeatils");

            migrationBuilder.RenameTable(
                name: "Customer_Record",
                newName: "customer_record");

            migrationBuilder.RenameTable(
                name: "CricketerDeatils",
                newName: "cricketer_details");

            migrationBuilder.AddPrimaryKey(
                name: "PK_customer_record",
                table: "customer_record",
                column: "Cus_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cricketer_details",
                table: "cricketer_details",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_customer_record",
                table: "customer_record");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cricketer_details",
                table: "cricketer_details");

            migrationBuilder.RenameTable(
                name: "customer_record",
                newName: "Customer_Record");

            migrationBuilder.RenameTable(
                name: "cricketer_details",
                newName: "CricketerDeatils");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer_Record",
                table: "Customer_Record",
                column: "Cus_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CricketerDeatils",
                table: "CricketerDeatils",
                column: "Id");
        }
    }
}
