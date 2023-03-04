using SimpleApi.Domain.Repository;
using SimpleApi.Domain.Repository.Interfaces;
using SimpleApi.Domain.Services;
using SimpleApi.Domain.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// File log
//var endpoint = new ExternalEndpoint();
//config.GetSection("ExternalEndpoint").Bind(endpoint);

//Log.Logger = new LoggerConfiguration()
//             .Enrich.FromLogContext()
//             .MinimumLevel.Debug()
//               .WriteTo.File(
//                  $@"{endpoint.LogPath}\BUlk_NIP_{DateTime.Now.ToString("yyyyMMdd")}.txt",
//              fileSizeLimitBytes: 10_000_000,
//              rollOnFileSizeLimit: true,
//              shared: true,
//              flushToDiskInterval: TimeSpan.FromSeconds(1))
//             .CreateLogger();

// Add services to the container.
var services = builder.Services;

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

services.AddSingleton<AppDbContext>();

services.AddScoped<IUserService, UserService>();
services.AddScoped<IGenericService, GenericService>();

services.AddScoped<IUserRepository, UserRepository>();

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

