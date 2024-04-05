using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArenaPhysics.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProblemUserProblem");

            migrationBuilder.DropTable(
                name: "UserUserProblem");

            migrationBuilder.AddColumn<int>(
                name: "CompetitionName",
                table: "Problems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Grade",
                table: "Problems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "Problems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UserProblems_ProblemId",
                table: "UserProblems",
                column: "ProblemId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProblems_UserId",
                table: "UserProblems",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserProblems_Problems_ProblemId",
                table: "UserProblems",
                column: "ProblemId",
                principalTable: "Problems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserProblems_Users_UserId",
                table: "UserProblems",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserProblems_Problems_ProblemId",
                table: "UserProblems");

            migrationBuilder.DropForeignKey(
                name: "FK_UserProblems_Users_UserId",
                table: "UserProblems");

            migrationBuilder.DropIndex(
                name: "IX_UserProblems_ProblemId",
                table: "UserProblems");

            migrationBuilder.DropIndex(
                name: "IX_UserProblems_UserId",
                table: "UserProblems");

            migrationBuilder.DropColumn(
                name: "CompetitionName",
                table: "Problems");

            migrationBuilder.DropColumn(
                name: "Grade",
                table: "Problems");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Problems");

            migrationBuilder.CreateTable(
                name: "ProblemUserProblem",
                columns: table => new
                {
                    ProblemsId = table.Column<int>(type: "int", nullable: false),
                    UserProblemsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProblemUserProblem", x => new { x.ProblemsId, x.UserProblemsId });
                    table.ForeignKey(
                        name: "FK_ProblemUserProblem_Problems_ProblemsId",
                        column: x => x.ProblemsId,
                        principalTable: "Problems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProblemUserProblem_UserProblems_UserProblemsId",
                        column: x => x.UserProblemsId,
                        principalTable: "UserProblems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserUserProblem",
                columns: table => new
                {
                    UserProblemsId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserUserProblem", x => new { x.UserProblemsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_UserUserProblem_UserProblems_UserProblemsId",
                        column: x => x.UserProblemsId,
                        principalTable: "UserProblems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserUserProblem_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProblemUserProblem_UserProblemsId",
                table: "ProblemUserProblem",
                column: "UserProblemsId");

            migrationBuilder.CreateIndex(
                name: "IX_UserUserProblem_UsersId",
                table: "UserUserProblem",
                column: "UsersId");
        }
    }
}
