using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HandlingDb.Migrations
{
    /// <inheritdoc />
    public partial class OrnamentalFishEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "car",
                columns: table => new
                {
                    car_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    car_make = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    car_model = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    car_year = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    car_color = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    vin_number = table.Column<string>(type: "character varying(17)", maxLength: 17, nullable: true),
                    owner_name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    registration_number = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    insurance_provider = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    insurance_policy_number = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_car", x => x.car_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "car");
        }
    }
}
