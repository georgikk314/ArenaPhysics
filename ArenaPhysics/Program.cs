using ArenaPhysics.Data;
using ArenaPhysics.Data.Repositories.Abstractions;
using ArenaPhysics.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using ArenaPhysics.Services.Abstractions;
using ArenaPhysics.Data.Entities;
using ArenaPhysics.Services;

namespace ArenaPhysics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            builder.Services.AddScoped<IUserProblemService, UserProblemService>();
            builder.Services.AddScoped<IProblemService, ProblemService>();
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
           

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}