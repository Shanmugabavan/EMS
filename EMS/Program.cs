using EMI.DTO.ConfigRepo;
using EMS.Entity.Context;
using EMS.Infrastructure.General;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var configRepository = new ConfigRepository(builder.Configuration);
configRepository.SetRepository();
builder.Services.AddDbContext<EmsFunctionContextWrite>(options =>
{
    options.UseNpgsql(ConfigRepo.WriteConnection);
});
builder.Services.AddAppDependencies(builder.Configuration);
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
