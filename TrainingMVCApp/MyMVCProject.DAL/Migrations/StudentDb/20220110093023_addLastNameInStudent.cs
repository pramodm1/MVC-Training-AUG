using Microsoft.EntityFrameworkCore.Migrations;

namespace MyMVCProject.DAL.Migrations.StudentDb
{
    public partial class addLastNameInStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Student",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Student");
        }
    }
}
