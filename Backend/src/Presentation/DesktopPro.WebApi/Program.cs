using DesktopPro.Persistence;
using DesktopPro.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

//API Services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

// OpenAPI (Swagger) Services
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // Enable OpenAPI (Swagger) in development environment
    app.MapOpenApi();

    // Enable Scalar API Reference in development environment
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();