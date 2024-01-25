﻿// <auto-generated />
using System;
using HandlingDb.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HandlingDb.Migrations
{
    [DbContext(typeof(TeamDbContext))]
<<<<<<<< HEAD:HandlingDb/Migrations/20240124202119_InitialCreate.Designer.cs
    [Migration("20240124202119_InitialCreate")]
========
    [Migration("20240125080710_InitialCreate")]
>>>>>>>> 8eb6dd43c6b2d65a47428e787c6a2f1d21c45c8d:HandlingDb/Migrations/20240125080710_InitialCreate.Designer.cs
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("HandlingDb.Models.Bike", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("brand");

                    b.Property<string>("ChassisNumber")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("chassis_number");

                    b.Property<string>("CubicCylinder")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("cubic_cylinder");

                    b.Property<string>("EngineNumber")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("engine_number");

                    b.Property<DateOnly>("ManufactureDate")
                        .HasColumnType("date")
                        .HasColumnName("manufacture_date");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("model");

                    b.Property<DateOnly>("RegistrationDate")
                        .HasColumnType("date")
                        .HasColumnName("registration_date");

                    b.Property<string>("SeatCapacity")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("seat_capacity");

                    b.Property<int>("WheelSize")
                        .HasColumnType("integer")
                        .HasColumnName("wheel_size");

                    b.HasKey("Id");

                    b.ToTable("bike");
                });

            modelBuilder.Entity("HandlingDb.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("category_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("category_name");

                    b.HasKey("Id");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("HandlingDb.Models.CricketerDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("player_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("address");

                    b.Property<string>("Address2")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("address2");

                    b.Property<string>("Address3")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("address3");

                    b.Property<string>("Address4")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("address4");

                    b.Property<string>("Age")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("character varying(2)")
                        .HasColumnName("age");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("city");

                    b.Property<bool>("Gender")
                        .HasColumnType("boolean")
                        .HasColumnName("gender");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("mobile");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("player_name");

                    b.Property<string>("Nation")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("nation");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("character varying(4)")
                        .HasColumnName("player_number");

                    b.HasKey("Id");

                    b.ToTable("cricketer_details");
                });

            modelBuilder.Entity("HandlingDb.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)")
                        .HasColumnName("addressLine1");

                    b.Property<string>("AddressLine2")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)")
                        .HasColumnName("addressLine2");

                    b.Property<string>("AddressLine3")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)")
                        .HasColumnName("addressLine3");

                    b.Property<string>("AddressLine4")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)")
                        .HasColumnName("addressLine4");

                    b.Property<DateTime>("DateOfBirth")
                        .HasMaxLength(500)
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("dateofbirth");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("name");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)")
                        .HasColumnName("phone");

                    b.Property<string>("PinCode")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)")
                        .HasColumnName("pinCode");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)")
                        .HasColumnName("state");

                    b.Property<bool>("SubscriptionStatus")
                        .HasMaxLength(500)
                        .HasColumnType("boolean")
                        .HasColumnName("subscriptionstatus");

                    b.HasKey("Id");

                    b.ToTable("customer_record");
                });

            modelBuilder.Entity("HandlingDb.Models.CustomerOrder", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("order_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("OrderId"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("integer")
                        .HasColumnName("customer_id");

                    b.Property<bool>("IsPaid")
                        .HasMaxLength(100)
                        .HasColumnType("boolean")
                        .HasColumnName("is_paid");

                    b.Property<DateTime>("OrderDate")
                        .HasMaxLength(100)
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("order_date");

                    b.Property<string>("OrderName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("order_name");

                    b.Property<string>("OrderStatus")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("order_status");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("payment_method");

                    b.Property<string>("ShippingAderess")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("shipping_Address");

                    b.Property<decimal>("TotalAmount")
                        .HasMaxLength(100)
                        .HasColumnType("numeric")
                        .HasColumnName("total_amount");

                    b.Property<string>("TrackingNumber")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("tracking-number");

                    b.HasKey("OrderId");

                    b.ToTable("order_record");
                });

            modelBuilder.Entity("HandlingDb.Models.Desktop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("desktop_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("brand");

                    b.Property<string>("Graphics")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("graphics");

                    b.Property<DateOnly>("ManufactureDate")
                        .HasColumnType("date")
                        .HasColumnName("manufacture_date");

                    b.Property<string>("Os")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("os");

                    b.Property<string>("OsVersion")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("os_version");

                    b.Property<int>("Price")
                        .HasColumnType("integer")
                        .HasColumnName("price");

                    b.Property<string>("Processor")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("processor");

                    b.Property<string>("Ram")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("ram");

                    b.Property<string>("Rom")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("rom");

                    b.Property<string>("Ssd")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("ssd");

                    b.HasKey("Id");

                    b.ToTable("desktop");
                });

            modelBuilder.Entity("HandlingDb.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("item_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("item_name");

                    b.Property<int?>("SubCategoryId")
                        .HasColumnType("integer")
                        .HasColumnName("sub_category_id");

                    b.HasKey("Id");

                    b.HasIndex("SubCategoryId");

                    b.ToTable("item");
                });

            modelBuilder.Entity("HandlingDb.Models.Mobile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("mobile_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("brand");

                    b.Property<string>("Graphics")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("graphics");

                    b.Property<DateOnly>("ManufactureDate")
                        .HasColumnType("date")
                        .HasColumnName("manufacture_date");

                    b.Property<string>("Os")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("os");

                    b.Property<string>("OsVersion")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("os_version");

                    b.Property<int>("Price")
                        .HasColumnType("integer")
                        .HasColumnName("price");

                    b.Property<string>("Processor")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("processor");

                    b.Property<string>("Ram")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("ram");

                    b.Property<string>("Rom")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("rom");

                    b.HasKey("Id");

                    b.ToTable("mobile");
                });

            modelBuilder.Entity("HandlingDb.Models.OrnamentalFish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Colour")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("colour");

                    b.Property<string>("Food")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("food");

                    b.Property<string>("LifeSpan")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("life_span");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Origin")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("origin");

                    b.Property<string>("PackingFee")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("packing_fee");

                    b.Property<string>("PricePerPair")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("price_per_pair");

                    b.Property<string>("PricePerPiece")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("price_per_piece");

                    b.Property<string>("Water")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("water");

                    b.HasKey("Id");

                    b.ToTable("ornamental_fish");
                });

            modelBuilder.Entity("HandlingDb.Models.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("item_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("item_name");

                    b.Property<int?>("SubCategoryId")
                        .HasColumnType("integer")
                        .HasColumnName("sub_category_id");

                    b.HasKey("Id");

                    b.HasIndex("SubCategoryId");

                    b.ToTable("item");
                });

            modelBuilder.Entity("HandlingDb.Models.StudentRegister", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("address");

                    b.Property<string>("BloodGroup")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("blood_group");

                    b.Property<string>("Class")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("class");

                    b.Property<DateOnly>("Dob")
                        .HasColumnType("date")
                        .HasColumnName("dob");

                    b.Property<string>("FatherName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("father_name");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Section")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("section");

                    b.HasKey("Id");

                    b.ToTable("student_register");
                });

            modelBuilder.Entity("HandlingDb.Models.SubCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("sub_category_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer")
                        .HasColumnName("category_id");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("sub_category_name");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("sub_categories");
                });

<<<<<<<< HEAD:HandlingDb/Migrations/20240124202119_InitialCreate.Designer.cs
            modelBuilder.Entity("HandlingDb.Models.Item", b =>
========
            modelBuilder.Entity("HandlingDb.Models.Products", b =>
>>>>>>>> 8eb6dd43c6b2d65a47428e787c6a2f1d21c45c8d:HandlingDb/Migrations/20240125080710_InitialCreate.Designer.cs
                {
                    b.HasOne("HandlingDb.Models.SubCategory", "SubCategory")
                        .WithMany("Items")
                        .HasForeignKey("SubCategoryId");

                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("HandlingDb.Models.SubCategory", b =>
                {
                    b.HasOne("HandlingDb.Models.Category", "Category")
                        .WithMany("SubCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("HandlingDb.Models.Category", b =>
                {
                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("HandlingDb.Models.SubCategory", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
