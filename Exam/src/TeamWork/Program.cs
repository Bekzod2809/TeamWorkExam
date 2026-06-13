using Serilog;
using TeamWork.Configurations;
using TeamWork.Repositories;
using TeamWork.Services;

namespace TeamWork
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Serilog sozlash
            builder.ConfigureSerilog();

            // Add services to the container.
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.ConfigureDB();

            builder.Services.AddScoped<IFoodRepository, FoodRepository>();
            builder.Services.AddScoped<IFoodService, FoodService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            // Har bir requestni log qiladi
            app.UseSerilogRequestLogging();

            app.UseHttpsRedirection();

            // Exceptionlarni log qiladi
            app.UseExceptionHandler(errorApp =>
            {
                errorApp.Run(async context =>
                {
                    var error = context.Features.Get<Microsoft.AspNetCore.Diagnostics.IExceptionHandlerFeature>();
                    if (error != null)
                    {
                        Log.Error(error.Error, "Unhandled exception occurred");
                    }
                    context.Response.StatusCode = 500;
                    await context.Response.WriteAsync("Internal Server Error");
                });
            });

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}