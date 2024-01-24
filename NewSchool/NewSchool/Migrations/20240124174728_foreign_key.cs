using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewSchool.Migrations
{
    /// <inheritdoc />
    public partial class foreign_key : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "teacher_record",
                table: "school");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "student",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "student_id",
                table: "school",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_student_StudentId",
                table: "student",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_school_student_id",
                table: "school",
                column: "student_id");

            migrationBuilder.AddForeignKey(
                name: "FK_school_student_student_id",
                table: "school",
                column: "student_id",
                principalTable: "student",
                principalColumn: "student_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_student_student_StudentId",
                table: "student",
                column: "StudentId",
                principalTable: "student",
                principalColumn: "student_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_school_student_student_id",
                table: "school");

            migrationBuilder.DropForeignKey(
                name: "FK_student_student_StudentId",
                table: "student");

            migrationBuilder.DropIndex(
                name: "IX_student_StudentId",
                table: "student");

            migrationBuilder.DropIndex(
                name: "IX_school_student_id",
                table: "school");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "student");

            migrationBuilder.DropColumn(
                name: "student_id",
                table: "school");

            migrationBuilder.AddColumn<string>(
                name: "teacher_record",
                table: "school",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
