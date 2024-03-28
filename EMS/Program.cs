using EMI.DTO.ConfigRepo;
using EMS.Entity.Context;
using EMS.Infrastructure.General;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var configRepository = new ConfigRepository(builder.Configuration);
configRepository.SetRepository();
builder.Services.AddDbContext<EMSFunctionContextWrite>(options =>
{
    options.UseNpgsql("Host=localhost;Port=5432;Database=EMS;Username=postgres;Password=25621;");
});
//builder.Services.AddReadinessCheck(); // Monitor app readiness
//builder.Services.AddDBCheck<ERFunctionContextRead>(); // Monitor db liveness
//builder.Services.AddDBCheck<ERFunctionContextWrite>(); // Monitor another db liveness

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
