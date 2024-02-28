using ShopeeBE.BL.Interfaces;
using ShopeeBE.BL.Services;
using ShopeeBE.DL.Database;
using ShopeeBE.DL.Helpers;
using ShopeeBE.DL.Interfaces;
using ShopeeBE.DL.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IDatabaseConnection, DatabaseConnection>();
builder.Services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
builder.Services.AddScoped(typeof(IBaseDL<>), typeof(BaseDL<>));

var app = builder.Build();

DatabaseContext.ConnectionString =  builder.Configuration.GetConnectionString("MySqlLocal");

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
