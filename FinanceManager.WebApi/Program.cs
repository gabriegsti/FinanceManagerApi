using FinanceManager.BrapiApiClient;
using FinanceManager.Domain.Interfaces;
using FinanceManager.Application.DependencyInjection;
using FinanceManger.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using FinanceManager.ApiClient.DependencyInjection;
using FinanceManager.Infrastructure.DependencyInjection;
using Azure.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

//TODO: Some dependency injections are missing. Fix here!
builder.Services.AddFinanceManagerServicesExtensions();
builder.Services.AddBraApiClientExtensions();
builder.Services.AddInfrastructure(builder.Configuration);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
