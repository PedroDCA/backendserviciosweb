using Microsoft.EntityFrameworkCore;
using ProductionBusinessLayer.ServiceInterfaces;
using ProductionBusinessLayer.Services;
using ProductionDataAccessLayer.DataAccesses;
using ProductionDataAccessLayer.ServiceInterfaces;
using ProductionDataAccessLayer.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string azureConnectionString = "Server=serviciosweb.mysql.database.azure.com;Port=3306;Database=integration;Uid=serviciosweb;Pwd=hola1234@;SslMode=Preferred;";
builder.Services.AddDbContext<MySQLConnection>(options => options.UseMySQL(azureConnectionString));

builder.Services.AddScoped<IEmployeeDataAccess, EmployeeDataAccess>();
builder.Services.AddScoped<ISessionService, SessionService>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IMaterialDataAccess, MaterialDataAccess>();
builder.Services.AddScoped<IMaterialService, MaterialService>();
builder.Services.AddControllers();
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
