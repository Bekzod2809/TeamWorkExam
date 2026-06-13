using Microsoft.EntityFrameworkCore;
using TeamWork.Data;

namespace TeamWork.Configurations;

public static class DatabaseConfigurations
{
    // 'this WebApplicationBuilder builder' qismi juda muhim
    public static void ConfigureDB(this WebApplicationBuilder builder)
    {
        // appsettings.json dagi nomi bilan bir xil bo'lishi shart
        var connectionString = builder.Configuration.GetConnectionString("DatabaseConnection");

        builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(connectionString));
    }
}