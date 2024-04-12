using ArenaPhysics.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ArenaPhysics.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            /*
            modelBuilder.Entity<User>()
                .HasMany(t => t.Comments)
                .WithMany(e => e.Problems)
                .UsingEntity(join => join.ToTable("Comment"));

            modelBuilder.Entity<Problem>()
                        .HasMany(t => t.UserProblems)
                        .WithMany(e => e.Users)
                        .UsingEntity(join => join.ToTable("UserProblems"));
            

            base.OnModelCreating(modelBuilder);*/
        }

        public DbSet<Problem> Problems { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<UserProblem> UserProblems { get; set; }


    }
}
