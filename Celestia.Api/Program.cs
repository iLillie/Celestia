using System.Text.Json.Serialization;
using Celestia.Api.Configuration;
using Celestia.Api.Interfaces;
using Celestia.Api.Services;
using Celestia.Data;
using Celestia.Models;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});

builder.Services.AddCors(options => options.AddPolicy("All", build => build.AllowAnyHeader()
    .AllowAnyOrigin()
    .AllowAnyMethod()));

builder.Services.Configure<PostgresConfiguration>(builder.Configuration.GetSection("Postgres"));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo()
    {
        Title = "Celestia API",
        Version = "v1"
    });
});

builder.Services.ResolveDependencies();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}

app.UseCors("All");
app.UseRouting();
app.MapDefaultControllerRoute();

app.Run();