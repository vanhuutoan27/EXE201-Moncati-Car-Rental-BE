using Moncati_Car_API;
using Moncati_Car_API.Extensions;
using Moncati_Car_API.GlobalExceptions;

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
builder.Services.ConfigureJwtSetting(configuration);
builder.Services.ConfigureTokenAndManagerIdentity();

builder.Services.AddCustomJwtAuthentication(configuration);








// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
builder.Services.AddCustomSwagger();
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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.MigrationDatabase();

app.Run();
