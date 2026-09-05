using DesktopPro.Application;
using DesktopPro.Persistence;
using DesktopPro.Persistence.Contexts;
using DesktopPro.WebApi.Middlewares;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

//CORS Configuration
const string corsPolicyName = "DesktopProFrontend";

builder.Services.AddCors(options =>
{
    options.AddPolicy(corsPolicyName, policy =>
    {
        policy.WithOrigins("http://localhost:5173", "http://localhost:3000") // Vite and React ports
              .AllowAnyHeader()
              .AllowAnyMethod()
              .AllowCredentials(); // Necessary for cookies and authentication headers
    });
});


//Layer Records and Services
builder.Services.AddApplication();
builder.Services.AddPersistence(builder.Configuration);

//Cental Exception Handling and RFC7807 Problem Details Records
builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
builder.Services.AddProblemDetails();


//API Services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

// OpenAPI (Swagger) Services
builder.Services.AddOpenApi();

var app = builder.Build();

app.UseExceptionHandler();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // Enable OpenAPI (Swagger) in development environment
    app.MapOpenApi();

    // Enable Scalar API Reference in development environment
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.UseCors(corsPolicyName);

app.UseAuthorization();

app.MapControllers();

app.Run();