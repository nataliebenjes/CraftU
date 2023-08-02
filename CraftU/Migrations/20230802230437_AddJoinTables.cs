using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CraftU.Migrations
{
    public partial class AddJoinTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CraftCourseStudent",
                columns: table => new
                {
                    CraftCourseStudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CourseStudentId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CraftCourseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CraftCourseStudent", x => x.CraftCourseStudentId);
                    table.ForeignKey(
                        name: "FK_CraftCourseStudent_CraftCourses_CraftCourseId",
                        column: x => x.CraftCourseId,
                        principalTable: "CraftCourses",
                        principalColumn: "CraftCourseId");
                    table.ForeignKey(
                        name: "FK_CraftCourseStudent_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CraftCourseSupply",
                columns: table => new
                {
                    CraftCourseSupplyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CraftCourseId = table.Column<int>(type: "int", nullable: false),
                    SupplyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CraftCourseSupply", x => x.CraftCourseSupplyId);
                    table.ForeignKey(
                        name: "FK_CraftCourseSupply_CraftCourses_CraftCourseId",
                        column: x => x.CraftCourseId,
                        principalTable: "CraftCourses",
                        principalColumn: "CraftCourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CraftCourseSupply_Supplies_SupplyId",
                        column: x => x.SupplyId,
                        principalTable: "Supplies",
                        principalColumn: "SupplyId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_CraftCourseStudent_CraftCourseId",
                table: "CraftCourseStudent",
                column: "CraftCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CraftCourseStudent_StudentId",
                table: "CraftCourseStudent",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_CraftCourseSupply_CraftCourseId",
                table: "CraftCourseSupply",
                column: "CraftCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CraftCourseSupply_SupplyId",
                table: "CraftCourseSupply",
                column: "SupplyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CraftCourseStudent");

            migrationBuilder.DropTable(
                name: "CraftCourseSupply");
        }
    }
}
