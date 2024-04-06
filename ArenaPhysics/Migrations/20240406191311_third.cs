using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArenaPhysics.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserAnswer",
                table: "UserProblems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Answer",
                table: "Problems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserAnswer",
                table: "UserProblems");

            migrationBuilder.DropColumn(
                name: "Answer",
                table: "Problems");
        }
    }
}
