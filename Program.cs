using Microsoft.EntityFrameworkCore;
using Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options => {
  options.AddDefaultPolicy(builder => {
    builder.AllowAnyHeader();
    builder.AllowAnyMethod();
    builder.SetIsOriginAllowed(
        origin => { return new Uri(origin).Host == "localhost"; });
  });
});

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at
// https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ProductContext>(
    options => options.UseSqlServer(
        builder.Configuration.GetConnectionString("TestDB")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
