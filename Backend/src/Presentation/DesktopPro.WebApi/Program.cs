using DesktopPro.Application;
using DesktopPro.Persistence;
using DesktopPro.Persistence.Contexts;
using DesktopPro.WebApi.Middlewares;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

//Layer Records and Services
builder.Services.AddApplication();

//Cental Exception Handling and RFC7807 Problem Details Records
builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
builder.Services.AddProblemDetails();


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