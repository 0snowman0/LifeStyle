using LifeStyle.generic.Class;
using LifeStyle.generic.Interface;
using LifeStyle.Interface.Calculate;
using LifeStyle.Interface.Goals;
using LifeStyle.Interface.Info;
using LifeStyle.Model.Connection;
using LifeStyle.Model.Goals;
using LifeStyle.Repository.Calculate;
using LifeStyle.Repository.Goals;
using LifeStyle.Repository.Info;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();




//Add Db Context
builder.Services.AddDbContext<Context_En>(optionsAction: options =>
options.UseSqlServer(builder.Configuration["ConnectionStrings:DefaultConnection"]));


//Setting for Dapper
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddScoped<IDbConnection>(provider => new SqlConnection(connectionString));



//AutoMapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());





//generic
builder.Services.AddScoped<IGenericRepository,GenericRepository>();
builder.Services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
builder.Services.AddScoped(typeof(ISqlQueryUtil<>), typeof(DapperSqlQuery<>));


//Goal
builder.Services.AddScoped<IYearGoals,YearGoals_Rep>();

builder.Services.AddScoped<IGoalsMonth,GoalsMonth_Rep>();

builder.Services.AddScoped<IGoalsWeek,GoalsWeek_Rep>();


//Text
builder.Services.AddScoped<ITextDay,TextDay_Rep>();


//Calculate
builder.Services.AddScoped<ICalculate,Calculate_Rep>();








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
