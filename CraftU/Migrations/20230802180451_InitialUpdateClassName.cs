using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CraftU.Migrations
{
    public partial class InitialUpdateClassName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Suudents_CraftCourses_CraftCourseId",
                table: "Suudents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Suudents",
                table: "Suudents");

            migrationBuilder.RenameTable(
                name: "Suudents",
                newName: "Students");

            migrationBuilder.RenameIndex(
                name: "IX_Suudents_CraftCourseId",
                table: "Students",
                newName: "IX_Students_CraftCourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_CraftCourses_CraftCourseId",
                table: "Students",
                column: "CraftCourseId",
                principalTable: "CraftCourses",
                principalColumn: "CraftCourseId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_CraftCourses_CraftCourseId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Suudents");

            migrationBuilder.RenameIndex(
                name: "IX_Students_CraftCourseId",
                table: "Suudents",
                newName: "IX_Suudents_CraftCourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Suudents",
                table: "Suudents",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Suudents_CraftCourses_CraftCourseId",
                table: "Suudents",
                column: "CraftCourseId",
                principalTable: "CraftCourses",
                principalColumn: "CraftCourseId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
