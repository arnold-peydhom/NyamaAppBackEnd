using DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var DefaultConnectionString = "DefaultConnection";

builder.Services.AddDbContext<NyamaContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString(DefaultConnectionString))
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));

// Add services to the container.

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

// supplement
app.UseCors(x =>
{
    x.AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader();
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
