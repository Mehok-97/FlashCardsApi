using FlashCardsApi.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddDbContext<FlashCardsContext>(options=>options.UseInMemoryDatabase("FlashCardsList"));
builder.Services.AddDbContext<FlashCardsContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("connectString")));
//builder.Services.AddSwaggerGen();
var app = builder.Build();
//seeding

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    //app.UseSwagger();
    //app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
