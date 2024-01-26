using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace NewBrand.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "category_details",
                columns: table => new
                {
                    category_id = table.Column<int>(type: "integer", maxLength: 5, nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    category_name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    sub_category_id = table.Column<int>(type: "integer", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category_details", x => x.category_id);
                });

            migrationBuilder.CreateTable(
                name: "product_details",
                columns: table => new
                {
                    product_id = table.Column<int>(type: "integer", maxLength: 5, nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    product_name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    product_price = table.Column<decimal>(type: "numeric", maxLength: 5, nullable: false),
                    product_description = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    category_id = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: false),
                    sub_category_id = table.Column<int>(type: "integer", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product_details", x => x.product_id);
                });

            migrationBuilder.CreateTable(
                name: "sub_category",
                columns: table => new
                {
                    sub_category_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    sub_category_name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sub_category", x => x.sub_category_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "category_details");

            migrationBuilder.DropTable(
                name: "product_details");

            migrationBuilder.DropTable(
                name: "sub_category");
        }
    }
}
