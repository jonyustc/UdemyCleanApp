using System.Reflection;
using Application.ActivityFeature;
using Application.Core;
using Application.Interfaces;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Persistence.Repositories;
using Persistence.SeedData;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddFluentValidation(config =>
{
    config.RegisterValidatorsFromAssemblyContaining<Create>();
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(typeof(List.ActivityRequestHandler));
builder.Services.AddAutoMapper(typeof(AutomapperProfile).Assembly);
builder.Services.AddScoped(typeof(IReposotory<>),typeof(Repository<>));
builder.Services.AddScoped<IReportRepository,ReportRepository>();

builder.Services.AddDbContext<DataContext>(opt => 
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseAuthorization();

app.MapControllers();

var scope = app.Services.CreateScope();

var context = scope.ServiceProvider.GetRequiredService<DataContext>();  //app.Services.GetRequiredService<DataContext>();
await context.Database.MigrateAsync();
await SeedAppData.SeedAsync(context);



app.Run();
