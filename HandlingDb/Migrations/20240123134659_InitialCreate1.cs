using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HandlingDb.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "CricketerDeatils");

            migrationBuilder.DropTable(
                name: "Customer_Record");

            migrationBuilder.DropTable(
                name: "student_register");
        }
    }
}
