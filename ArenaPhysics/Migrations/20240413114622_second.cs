using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArenaPhysics.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PointsDistribution",
                table: "UserProblems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PointsDistribution",
                table: "Problems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PointsDistribution",
                table: "UserProblems");

            migrationBuilder.DropColumn(
                name: "PointsDistribution",
                table: "Problems");
        }
    }
}
