using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArenaPhysics.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProblemId = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Problems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Branches = table.Column<int>(type: "int", nullable: false),
                    Difficulty = table.Column<int>(type: "int", nullable: false),
                    Author = table.Column<int>(type: "int", nullable: false),
                    ProblemCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProblemFileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdditionalInformation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfFormulas = table.Column<int>(type: "int", nullable: false),
                    OfficialAnswers = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Problems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserProblems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProblemId = table.Column<int>(type: "int", nullable: false),
                    Points = table.Column<double>(type: "float", nullable: false),
                    IsSolved = table.Column<bool>(type: "bit", nullable: false),
                    UserAnswerFileName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProblems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    DateOfCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProblemsPoints = table.Column<double>(type: "float", nullable: false),
                    NumberOfProblemsSolved = table.Column<int>(type: "int", nullable: false),
                    MechProblemsPoints = table.Column<double>(type: "float", nullable: false),
                    MechProblemsSolved = table.Column<int>(type: "int", nullable: false),
                    ElecProblemsPoints = table.Column<double>(type: "float", nullable: false),
                    ElecProblemsSolved = table.Column<int>(type: "int", nullable: false),
                    ThermoProblemsPoints = table.Column<double>(type: "float", nullable: false),
                    ThermoProblemsSolved = table.Column<int>(type: "int", nullable: false),
                    OpticsProblemsPoints = table.Column<double>(type: "float", nullable: false),
                    OpticsProblemsSolved = table.Column<int>(type: "int", nullable: false),
                    WavesProblemsPoints = table.Column<double>(type: "float", nullable: false),
                    WavesProblemsSolved = table.Column<int>(type: "int", nullable: false),
                    RelProblemsPoints = table.Column<double>(type: "float", nullable: false),
                    RelProblemsSolved = table.Column<int>(type: "int", nullable: false),
                    ModernProblemsPoints = table.Column<double>(type: "float", nullable: false),
                    ModernProblemsSolved = table.Column<int>(type: "int", nullable: false),
                    EasyProblemsPoints = table.Column<double>(type: "float", nullable: false),
                    EasyProblemsSolved = table.Column<int>(type: "int", nullable: false),
                    MediumProblemsPoints = table.Column<double>(type: "float", nullable: false),
                    MediumProblemsSolved = table.Column<int>(type: "int", nullable: false),
                    HardProblemsPoints = table.Column<double>(type: "float", nullable: false),
                    HardProblemsSolved = table.Column<int>(type: "int", nullable: false),
                    VeryHardProblemsPoints = table.Column<double>(type: "float", nullable: false),
                    VeryHardProblemsSolved = table.Column<int>(type: "int", nullable: false),
                    SeventhGradeProblemsSolved = table.Column<int>(type: "int", nullable: false),
                    EighthGradeProblemsSolved = table.Column<int>(type: "int", nullable: false),
                    NinthGradeProblemsSolved = table.Column<int>(type: "int", nullable: false),
                    TenthGradeProblemsSolved = table.Column<int>(type: "int", nullable: false),
                    EleventhGradeProblemsSolved = table.Column<int>(type: "int", nullable: false),
                    TwelvethGradeProblemsSolved = table.Column<int>(type: "int", nullable: false),
                    SpecialProblemsSolved = table.Column<int>(type: "int", nullable: false),
                    InternationalCompetitionsProblemsSolved = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CommentProblem",
                columns: table => new
                {
                    CommentsId = table.Column<int>(type: "int", nullable: false),
                    ProblemsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentProblem", x => new { x.CommentsId, x.ProblemsId });
                    table.ForeignKey(
                        name: "FK_CommentProblem_Comments_CommentsId",
                        column: x => x.CommentsId,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommentProblem_Problems_ProblemsId",
                        column: x => x.ProblemsId,
                        principalTable: "Problems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "CommentUser",
                columns: table => new
                {
                    CommentsId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentUser", x => new { x.CommentsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_CommentUser_Comments_CommentsId",
                        column: x => x.CommentsId,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommentUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
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
                name: "IX_CommentProblem_ProblemsId",
                table: "CommentProblem",
                column: "ProblemsId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentUser_UsersId",
                table: "CommentUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_ProblemUserProblem_UserProblemsId",
                table: "ProblemUserProblem",
                column: "UserProblemsId");

            migrationBuilder.CreateIndex(
                name: "IX_UserUserProblem_UsersId",
                table: "UserUserProblem",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommentProblem");

            migrationBuilder.DropTable(
                name: "CommentUser");

            migrationBuilder.DropTable(
                name: "ProblemUserProblem");

            migrationBuilder.DropTable(
                name: "UserUserProblem");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Problems");

            migrationBuilder.DropTable(
                name: "UserProblems");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
