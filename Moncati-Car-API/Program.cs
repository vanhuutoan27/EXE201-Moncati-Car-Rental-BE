using MocatiCar.Core.SeedWorks;
using MocatiCar.Core.Services;
using Moncati_Car_API;
using Moncati_Car_API.Extensions;
using Moncati_Car_API.GlobalExceptions;
using MoncatiCar.Data.SeedWork;
using MoncatiCar.Data.Services;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
// Add services to the container.

builder.Services.AddControllers();

builder.Services.ConfigureIdentity();
builder.Services.ConfigureCors();
builder.Services.ConfigureRepositoryManager();
builder.Services.ConfigureServiceManager();
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.ConfigureSqlContext(configuration);
builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
builder. Services.AddTransient<ICarService, CarService>();












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
app.UseCors("CorsPolicy");

app.UseExceptionHandler(opt => { });

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MigrationDatabase();

app.Run();
