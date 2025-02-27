using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using BangazonBE.Models.cs;
using System.Text.Json.Serialization;
using BangazonBE;
using Microsoft.AspNetCore.Http.Json;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

AppContext.SetSwitch("Npgsql.EnableTimestampBehavior", true);
builder.Services.AddNpgsql<BangazonDbContext>(builder.Configuration["BangazonBEDbConnectionString"]);
builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});




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
