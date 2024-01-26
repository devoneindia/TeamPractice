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
                name: "cricketer_details",
                columns: table => new
                {
                    player_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    player_name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    player_number = table.Column<string>(type: "character varying(4)", maxLength: 4, nullable: true),
                    gender = table.Column<bool>(type: "boolean", nullable: false),
                    age = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: true),
                    city = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    nation = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    mobile = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    address = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    address2 = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    address3 = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    address4 = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cricketer_details", x => x.player_id);
                });

            migrationBuilder.CreateTable(
                name: "desktop",
                columns: table => new
                {
                    desktop_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    brand = table.Column<string>(type: "text", nullable: false),
                    processor = table.Column<string>(type: "text", nullable: false),
                    ram = table.Column<string>(type: "text", nullable: false),
                    rom = table.Column<string>(type: "text", nullable: false),
                    graphics = table.Column<string>(type: "text", nullable: false),
                    ssd = table.Column<string>(type: "text", nullable: false),
                    os = table.Column<string>(type: "text", nullable: false),
                    os_version = table.Column<string>(type: "text", nullable: false),
                    price = table.Column<int>(type: "integer", nullable: false),
                    manufacture_date = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_desktop", x => x.desktop_id);
                });

            migrationBuilder.CreateTable(
                name: "fish_food",
                columns: table => new
                {
                    food_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    food_name = table.Column<string>(type: "text", nullable: false),
                    food_price = table.Column<string>(type: "text", nullable: false),
                    FishFoodFoodId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fish_food", x => x.food_id);
                    table.ForeignKey(
                        name: "FK_fish_food_fish_food_FishFoodFoodId",
                        column: x => x.FishFoodFoodId,
                        principalTable: "fish_food",
                        principalColumn: "food_id");
                });

            migrationBuilder.CreateTable(
                name: "mobile",
                columns: table => new
                {
                    mobile_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    brand = table.Column<string>(type: "text", nullable: false),
                    processor = table.Column<string>(type: "text", nullable: false),
                    ram = table.Column<string>(type: "text", nullable: false),
                    rom = table.Column<string>(type: "text", nullable: false),
                    graphics = table.Column<string>(type: "text", nullable: false),
                    os = table.Column<string>(type: "text", nullable: false),
                    os_version = table.Column<string>(type: "text", nullable: false),
                    price = table.Column<int>(type: "integer", nullable: false),
                    manufacture_date = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mobile", x => x.mobile_id);
                });

            migrationBuilder.CreateTable(
                name: "prav_categories",
                columns: table => new
                {
                    category_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    category_name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prav_categories", x => x.category_id);
                });

            migrationBuilder.CreateTable(
                name: "product",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    price = table.Column<decimal>(type: "numeric", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product", x => x.id);
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

            migrationBuilder.CreateTable(
                name: "aquarium_shop",
                columns: table => new
                {
                    shop_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    shop_name = table.Column<string>(type: "text", nullable: false),
                    price_per_piece = table.Column<string>(type: "text", nullable: false),
                    price_per_pair = table.Column<string>(type: "text", nullable: false),
                    packing_fee = table.Column<string>(type: "text", nullable: false),
                    food_name = table.Column<string>(type: "text", nullable: false),
                    FishFoodFoodId = table.Column<int>(type: "integer", nullable: false),
                    FoodPrice = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aquarium_shop", x => x.shop_id);
                    table.ForeignKey(
                        name: "FK_aquarium_shop_fish_food_FishFoodFoodId",
                        column: x => x.FishFoodFoodId,
                        principalTable: "fish_food",
                        principalColumn: "food_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "prav_sub_categories",
                columns: table => new
                {
                    sub_category_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    sub_category_name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    category_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prav_sub_categories", x => x.sub_category_id);
                    table.ForeignKey(
                        name: "FK_prav_sub_categories_prav_categories_category_id",
                        column: x => x.category_id,
                        principalTable: "prav_categories",
                        principalColumn: "category_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "customer_record",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    product_id = table.Column<int>(type: "integer", nullable: false),
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
                    table.PrimaryKey("PK_customer_record", x => x.id);
                    table.ForeignKey(
                        name: "FK_customer_record_product_product_id",
                        column: x => x.product_id,
                        principalTable: "product",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
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
                    AquariumShopId = table.Column<int>(type: "integer", nullable: true),
                    price_per_pair = table.Column<string>(type: "text", nullable: false),
                    packing_fee = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ornamental_fish", x => x.id);
                    table.ForeignKey(
                        name: "FK_ornamental_fish_aquarium_shop_AquariumShopId",
                        column: x => x.AquariumShopId,
                        principalTable: "aquarium_shop",
                        principalColumn: "shop_id");
                });

            migrationBuilder.CreateTable(
                name: "prav_product_details",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SubCategoryId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prav_product_details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_prav_product_details_prav_sub_categories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "prav_sub_categories",
                        principalColumn: "sub_category_id");
                });

            migrationBuilder.CreateTable(
                name: "order_record",
                columns: table => new
                {
                    order_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    order_name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    product_id = table.Column<int>(type: "integer", nullable: false),
                    customer_id = table.Column<int>(type: "integer", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_order_record_customer_record_customer_id",
                        column: x => x.customer_id,
                        principalTable: "customer_record",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_order_record_product_product_id",
                        column: x => x.product_id,
                        principalTable: "product",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_aquarium_shop_FishFoodFoodId",
                table: "aquarium_shop",
                column: "FishFoodFoodId");

            migrationBuilder.CreateIndex(
                name: "IX_customer_record_product_id",
                table: "customer_record",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_fish_food_FishFoodFoodId",
                table: "fish_food",
                column: "FishFoodFoodId");

            migrationBuilder.CreateIndex(
                name: "IX_order_record_customer_id",
                table: "order_record",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_order_record_product_id",
                table: "order_record",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_ornamental_fish_AquariumShopId",
                table: "ornamental_fish",
                column: "AquariumShopId");

            migrationBuilder.CreateIndex(
                name: "IX_prav_product_details_SubCategoryId",
                table: "prav_product_details",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_prav_sub_categories_category_id",
                table: "prav_sub_categories",
                column: "category_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bike");

            migrationBuilder.DropTable(
                name: "cricketer_details");

            migrationBuilder.DropTable(
                name: "desktop");

            migrationBuilder.DropTable(
                name: "mobile");

            migrationBuilder.DropTable(
                name: "order_record");

            migrationBuilder.DropTable(
                name: "ornamental_fish");

            migrationBuilder.DropTable(
                name: "prav_product_details");

            migrationBuilder.DropTable(
                name: "student_register");

            migrationBuilder.DropTable(
                name: "customer_record");

            migrationBuilder.DropTable(
                name: "aquarium_shop");

            migrationBuilder.DropTable(
                name: "prav_sub_categories");

            migrationBuilder.DropTable(
                name: "product");

            migrationBuilder.DropTable(
                name: "fish_food");

            migrationBuilder.DropTable(
                name: "prav_categories");
        }
    }
}
