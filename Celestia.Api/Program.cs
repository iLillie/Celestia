using System.Text.Json.Serialization;
using Celestia.Api.Interfaces;
using Celestia.Api.Services;
using Celestia.Data;
using Celestia.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers().AddJsonOptions(options => 
{ 
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});;
builder.Services.AddCors(options => options.AddPolicy("All", build => build.AllowAnyHeader()
    .AllowAnyOrigin()
    .AllowAnyMethod()));
builder.Services.Configure<PostgresConfiguration>(builder.Configuration.GetSection("Postgres"));
builder.Services.AddDbContext<ApplicationDbContext>();
builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddScoped<IPositionService, PositionService>();


var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseCors("All");
app.UseRouting();
app.MapDefaultControllerRoute();

app.Run();