using FluentValidation;
using System.Text.Json.Serialization;
using TestMinimalAPI.Models;
using TestMinimalAPI.Modules;
using TestMinimalAPI.Validation;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Enums to string 
builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(opt =>
{
    opt.SerializerOptions.Converters.Add(new JsonStringEnumConverter());
});

// FluentValidation
builder.AddFluentValidationEndpointFilter();
builder.Services.AddScoped<IValidator<Cat>, CatValidator>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Register MinimalAPI modules
app.RegisterCatsModuleEndpoints();
app.RegisterWeatherDataModule();

app.Run();
