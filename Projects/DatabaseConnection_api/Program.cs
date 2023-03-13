using DatabaseConnection_api.domain.Repository;
using DatabaseConnection_api.domain.Repository.Interfaces;
using DatabaseConnection_api.domain.Services;
using DatabaseConnection_api.domain.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

services.AddSingleton<AppDbContext>();

services.AddScoped<IUserService, UserService>();
services.AddScoped<ICustomerServices, CustomerService>();


services.AddScoped<IUserRepository, UserRepository>();
services.AddScoped<ICustomerRepository, CustomerRepository>();

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
