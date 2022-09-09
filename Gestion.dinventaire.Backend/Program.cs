using Gestion.dinventaire.Backend.DAL.Enteties;
using Gestion.dinventaire.Backend.DAL.Repositories;
using Gestion.dinventaire.Backend.JWTAuthentification;
using Gestion.dinventaire.Backend.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using XAct.Domain.Repositories;
using XAct.Library.Constants;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<APIContext>(options =>
                   options.UseSqlServer(builder.Configuration.GetConnectionString("DBConnection")));


builder.Services.AddScoped<IJWTManagerRepository,JWTManagerRepository>();
builder.Services.AddTransient(typeof(EmployeeRepository));
builder.Services.AddTransient(typeof(ComputerRepository));
builder.Services.AddTransient(typeof(ChaiseRepository));
builder.Services.AddTransient(typeof(ClavierRepository));
builder.Services.AddTransient(typeof(TableRepository));
builder.Services.AddTransient<TableRepository>();

        
      

                


// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
