using Btm.Api.Data.Connections;
using Btm.Api.Data.Context;
using Btm.Api.Data.DataAccess;
using Btm.Api.Data.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Set the environment based on the command-line arguments or the default environment
var environment = builder.Environment.IsDevelopment() ? "Development" : "Production";
    Console.WriteLine($"Environment is: {builder.Environment}");

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//string appSettingsFile =
//    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "appsettings.json");
//if (environment == "Development")
//{
//    appSettingsFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), $"appsettings.{environment}.json");
//}
// Build the configuration
var configuration = new ConfigurationBuilder()
    .SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile($"appsettings.{environment}.json", optional: true, reloadOnChange: true) // Optional appsettings.dev.json for development
    .Build();

// Bind the configuration to the DatabaseSettings class
var databaseSettings = new DatabaseSettings();
configuration.GetSection("SqlServerDatabase").Bind(databaseSettings);

// Add the database settings to the service container
builder.Services.AddSingleton(databaseSettings);
builder.Services.AddSingleton<IDataConnection>(new DataConnection(databaseSettings));

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(databaseSettings.ConnectionString);
});

// Register services in the dependency injection container
builder.Services.AddScoped<IContractCategoryService, ContractCategoryService>();
//builder.Services.AddScoped<IContractCategoryDataAccess, ContractCategoryDataAccess>();
//builder.Services.AddScoped<IContractCategoryDataAccess>(provider =>
//{
//    var dbContext = provider.GetRequiredService<AppDbContext>();
//    var logger = provider.GetRequiredService<ILogger<ContractCategoryDataAccess>>();
//    return new ContractCategoryDataAccess(dbContext, logger);
//});

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
