using Btm.Api.Web.Connections;
using Btm.Api.Web.DataContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Build the configuration
var configuration = new ConfigurationBuilder()
    .SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile("appsettings.dev.json", optional: true, reloadOnChange: true) // Optional appsettings.dev.json for development
    .Build();

// Bind the configuration to the DatabaseSettings class
var databaseSettings = new DatabaseSettings();
configuration.GetSection("SqlServerDatabase").Bind(databaseSettings);

// Add the database settings to the service container
builder.Services.AddSingleton(databaseSettings);

// Create instances of DataContexts
var readOnlyDataContext = new ReadOnlyDataContext(databaseSettings.ReadOnlyConnection);
var adminDataContext = new AdminDataContext(databaseSettings.AdminOnlyConnection);

// Register DataContexts in the service container
builder.Services.AddSingleton<IDataContext>(readOnlyDataContext);
builder.Services.AddSingleton<IDataContext>(adminDataContext);

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
