
using LibraryAPI.Model;
using LibraryAPI.structure;
using Microsoft.EntityFrameworkCore;

namespace ApiSolo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aSystem.InvalidOperationException: 'The service collection cannot be modified because it is read-only.'ka.ms/aspnet/openapi
            builder.Services.AddOpenApi();
            //inserção de independencia
            builder.Services.AddScoped<IBookRepository, BookRepositery>();

            //swagger
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //banco de dados
            builder.Services.AddDbContext<ConectionContext>(options =>
                options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"))
            );

            var app = builder.Build();


            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseSwagger();
            app.UseSwaggerUI();

            app.MapControllers();

            app.Run();
        }
    }
}
