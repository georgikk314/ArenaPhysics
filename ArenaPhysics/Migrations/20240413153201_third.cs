using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArenaPhysics.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserProblems_AspNetUsers_UserId1",
                table: "UserProblems");

            migrationBuilder.DropIndex(
                name: "IX_UserProblems_UserId1",
                table: "UserProblems");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "UserProblems");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserProblems",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_UserProblems_UserId",
                table: "UserProblems",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserProblems_AspNetUsers_UserId",
                table: "UserProblems",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserProblems_AspNetUsers_UserId",
                table: "UserProblems");

            migrationBuilder.DropIndex(
                name: "IX_UserProblems_UserId",
                table: "UserProblems");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "UserProblems",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "UserProblems",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserProblems_UserId1",
                table: "UserProblems",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_UserProblems_AspNetUsers_UserId1",
                table: "UserProblems",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
