using Microsoft.EntityFrameworkCore;
using OnlineStore.Infrastructures.Data.SqlServer.Common;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//باید کانکشن استرینگ به دیبی کانتکست وصل کنیم
builder.Services.AddDbContext<OnlineStoreCommandDbContext>(option =>
    option.UseSqlServer(builder.Configuration.GetConnectionString("OnlineStoreCommandsConnectionString")));


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
