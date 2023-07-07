using Btm.Api.Library.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Create a new Configuration object that includes both appsettings.json and user secrets
var configuration = new ConfigurationBuilder()
    .SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddUserSecrets<Program>()
    .Build();

// Add services to the container.
builder.Services.AddControllersWithViews();

// Configure DbContext
builder.Services.AddDbContext<ReadOnlyDbContext>(options =>
{
    var connectionString = configuration.GetConnectionString("ReadOnlyConnection");
    options.UseSqlServer(connectionString);
});

// Add CORS
builder.Services.AddCors(options => options.AddPolicy("BTMMainWebClient", policy =>
{
    policy.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod();
    //policy.WithOrigins("https://localhost:44491")
    //    .AllowAnyHeader()
    //    .AllowAnyMethod();
    //policy.WithOrigins("http://localhost:44491")
    //    .AllowAnyHeader()
    //    .AllowAnyMethod();
    //policy.WithOrigins("https://localhost:5228")
    //    .AllowAnyHeader()
    //    .AllowAnyMethod();
    //policy.WithOrigins("http://localhost:5228")
    //    .AllowAnyHeader()
    //    .AllowAnyMethod();
    //policy.WithOrigins("https://localhost:40027")
    //    .AllowAnyHeader()
    //    .AllowAnyMethod();
    //policy.WithOrigins("http://localhost:40027")
    //    .AllowAnyHeader()
    //    .AllowAnyMethod();
}));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen(c =>
//{
//    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
//});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    //app.UseSwagger();
    //app.UseSwaggerUI();
    //app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API v1"));
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseCors("BTMMainWebClient");
//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller}/{action=Index}/{id?}");

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller}/{action=Index}/{id?}");

    // Add your API endpoint route here
    endpoints.MapControllerRoute(
        name: "api",
        pattern: "api/{controller}/{action=Index}/{id?}");
});

app.MapFallbackToFile("index.html"); ;

app.Run();
