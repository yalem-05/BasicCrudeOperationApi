using Application.MapProfile;
using Application.Persistence;
using Infrastracture.Data;
using Infrastracture.Repository;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using MediatR;
using Application.Feature.Query.QueryHndler;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddAutoMapper(typeof(MapProfiles));
//builder.Services.AddAutoMapper(typeof(MapProfiles));
builder.Services.AddMediatR(typeof(ProductQueryHandler).Assembly);

builder.Services.AddScoped<IproductRepository, ProductRepository>();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
