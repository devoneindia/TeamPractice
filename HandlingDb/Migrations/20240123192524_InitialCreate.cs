using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HandlingDb.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bike",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    brand = table.Column<string>(type: "text", nullable: false),
                    model = table.Column<string>(type: "text", nullable: false),
                    manufacture_date = table.Column<DateOnly>(type: "date", nullable: false),
                    registration_date = table.Column<DateOnly>(type: "date", nullable: false),
                    cubic_cylinder = table.Column<string>(type: "text", nullable: false),
                    chassis_number = table.Column<string>(type: "text", nullable: false),
                    engine_number = table.Column<string>(type: "text", nullable: false),
                    wheel_size = table.Column<int>(type: "integer", nullable: false),
                    seat_capacity = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bike", x => x.id);
                });

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

            migrationBuilder.CreateTable(
                name: "CricketerDeatils",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Number = table.Column<string>(type: "text", nullable: false),
                    Gender = table.Column<string>(type: "text", nullable: false),
                    Age = table.Column<string>(type: "text", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false),
                    Nation = table.Column<string>(type: "text", nullable: false),
                    MobileNumber = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    Address2 = table.Column<string>(type: "text", nullable: false),
                    Address3 = table.Column<string>(type: "text", nullable: false),
                    Address4 = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CricketerDeatils", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer_Record",
                columns: table => new
                {
                    Cus_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Cus_name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    email = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    phone = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    addressLine1 = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    addressLine2 = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    addressLine3 = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    addressLine4 = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    state = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    pinCode = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    dateofbirth = table.Column<DateTime>(type: "timestamp without time zone", maxLength: 500, nullable: false),
                    subscriptionstatus = table.Column<bool>(type: "boolean", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer_Record", x => x.Cus_id);
                });

            migrationBuilder.CreateTable(
                name: "order_record",
                columns: table => new
                {
                    order_id = table.Column<string>(type: "text", nullable: false),
                    order_name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    order_date = table.Column<DateTime>(type: "timestamp without time zone", maxLength: 100, nullable: false),
                    total_amount = table.Column<decimal>(type: "numeric", maxLength: 100, nullable: false),
                    shipping_Address = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    payment_method = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    is_paid = table.Column<bool>(type: "boolean", maxLength: 100, nullable: false),
                    order_status = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    trackingnumber = table.Column<string>(name: "tracking-number", type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order_record", x => x.order_id);
                });

            migrationBuilder.CreateTable(
                name: "ornamental_fish",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    life_span = table.Column<string>(type: "text", nullable: false),
                    water = table.Column<string>(type: "text", nullable: false),
                    colour = table.Column<string>(type: "text", nullable: false),
                    origin = table.Column<string>(type: "text", nullable: false),
                    food = table.Column<string>(type: "text", nullable: false),
                    price_per_piece = table.Column<string>(type: "text", nullable: false),
                    price_per_pair = table.Column<string>(type: "text", nullable: false),
                    packing_fee = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ornamental_fish", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "student_register",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    father_name = table.Column<string>(type: "text", nullable: false),
                    dob = table.Column<DateOnly>(type: "date", nullable: false),
                    @class = table.Column<string>(name: "class", type: "text", nullable: false),
                    section = table.Column<string>(type: "text", nullable: false),
                    blood_group = table.Column<string>(type: "text", nullable: false),
                    address = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_student_register", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bike");

            migrationBuilder.DropTable(
                name: "car");

            migrationBuilder.DropTable(
                name: "CricketerDeatils");

            migrationBuilder.DropTable(
                name: "Customer_Record");

            migrationBuilder.DropTable(
                name: "order_record");

            migrationBuilder.DropTable(
                name: "ornamental_fish");

            migrationBuilder.DropTable(
                name: "student_register");
        }
    }
}
