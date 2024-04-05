﻿// <auto-generated />
using System;
using ArenaPhysics.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ArenaPhysics.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240405111944_second")]
    partial class second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ArenaPhysics.Data.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProblemId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("ArenaPhysics.Data.Entities.Problem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AdditionalInformation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Author")
                        .HasColumnType("int");

                    b.Property<int>("Branches")
                        .HasColumnType("int");

                    b.Property<int>("CompetitionName")
                        .HasColumnType("int");

                    b.Property<int>("Difficulty")
                        .HasColumnType("int");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfFormulas")
                        .HasColumnType("int");

                    b.Property<string>("OfficialAnswers")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProblemCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProblemFileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Problems");
                });

            modelBuilder.Entity("ArenaPhysics.Data.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("datetime2");

                    b.Property<double>("EasyProblemsPoints")
                        .HasColumnType("float");

                    b.Property<int>("EasyProblemsSolved")
                        .HasColumnType("int");

                    b.Property<int>("EighthGradeProblemsSolved")
                        .HasColumnType("int");

                    b.Property<double>("ElecProblemsPoints")
                        .HasColumnType("float");

                    b.Property<int>("ElecProblemsSolved")
                        .HasColumnType("int");

                    b.Property<int>("EleventhGradeProblemsSolved")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("HardProblemsPoints")
                        .HasColumnType("float");

                    b.Property<int>("HardProblemsSolved")
                        .HasColumnType("int");

                    b.Property<int>("InternationalCompetitionsProblemsSolved")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("MechProblemsPoints")
                        .HasColumnType("float");

                    b.Property<int>("MechProblemsSolved")
                        .HasColumnType("int");

                    b.Property<double>("MediumProblemsPoints")
                        .HasColumnType("float");

                    b.Property<int>("MediumProblemsSolved")
                        .HasColumnType("int");

                    b.Property<double>("ModernProblemsPoints")
                        .HasColumnType("float");

                    b.Property<int>("ModernProblemsSolved")
                        .HasColumnType("int");

                    b.Property<int>("NinthGradeProblemsSolved")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfProblemsSolved")
                        .HasColumnType("int");

                    b.Property<double>("OpticsProblemsPoints")
                        .HasColumnType("float");

                    b.Property<int>("OpticsProblemsSolved")
                        .HasColumnType("int");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ProblemsPoints")
                        .HasColumnType("float");

                    b.Property<double>("RelProblemsPoints")
                        .HasColumnType("float");

                    b.Property<int>("RelProblemsSolved")
                        .HasColumnType("int");

                    b.Property<int>("SeventhGradeProblemsSolved")
                        .HasColumnType("int");

                    b.Property<int>("SpecialProblemsSolved")
                        .HasColumnType("int");

                    b.Property<int>("TenthGradeProblemsSolved")
                        .HasColumnType("int");

                    b.Property<double>("ThermoProblemsPoints")
                        .HasColumnType("float");

                    b.Property<int>("ThermoProblemsSolved")
                        .HasColumnType("int");

                    b.Property<int>("TwelvethGradeProblemsSolved")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("VeryHardProblemsPoints")
                        .HasColumnType("float");

                    b.Property<int>("VeryHardProblemsSolved")
                        .HasColumnType("int");

                    b.Property<double>("WavesProblemsPoints")
                        .HasColumnType("float");

                    b.Property<int>("WavesProblemsSolved")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ArenaPhysics.Data.Entities.UserProblem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsSolved")
                        .HasColumnType("bit");

                    b.Property<double>("Points")
                        .HasColumnType("float");

                    b.Property<int>("ProblemId")
                        .HasColumnType("int");

                    b.Property<string>("UserAnswerFileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProblemId");

                    b.HasIndex("UserId");

                    b.ToTable("UserProblems");
                });

            modelBuilder.Entity("CommentProblem", b =>
                {
                    b.Property<int>("CommentsId")
                        .HasColumnType("int");

                    b.Property<int>("ProblemsId")
                        .HasColumnType("int");

                    b.HasKey("CommentsId", "ProblemsId");

                    b.HasIndex("ProblemsId");

                    b.ToTable("CommentProblem");
                });

            modelBuilder.Entity("CommentUser", b =>
                {
                    b.Property<int>("CommentsId")
                        .HasColumnType("int");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("CommentsId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("CommentUser");
                });

            modelBuilder.Entity("ArenaPhysics.Data.Entities.UserProblem", b =>
                {
                    b.HasOne("ArenaPhysics.Data.Entities.Problem", null)
                        .WithMany("UserProblems")
                        .HasForeignKey("ProblemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ArenaPhysics.Data.Entities.User", null)
                        .WithMany("UserProblems")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CommentProblem", b =>
                {
                    b.HasOne("ArenaPhysics.Data.Entities.Comment", null)
                        .WithMany()
                        .HasForeignKey("CommentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ArenaPhysics.Data.Entities.Problem", null)
                        .WithMany()
                        .HasForeignKey("ProblemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CommentUser", b =>
                {
                    b.HasOne("ArenaPhysics.Data.Entities.Comment", null)
                        .WithMany()
                        .HasForeignKey("CommentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ArenaPhysics.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ArenaPhysics.Data.Entities.Problem", b =>
                {
                    b.Navigation("UserProblems");
                });

            modelBuilder.Entity("ArenaPhysics.Data.Entities.User", b =>
                {
                    b.Navigation("UserProblems");
                });
#pragma warning restore 612, 618
        }
    }
}
