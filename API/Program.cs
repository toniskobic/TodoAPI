using BusinessLayer.DTOs;
using BusinessLayer.Interfaces;
using BusinessLayer.Services;
using DataLayer;
using DataLayer.Interfaces;
using DataLayer.Models;
using DataLayer.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

ConfigurationManager configuration = builder.Configuration;
// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<TodoContext>(opt =>
    opt.UseSqlServer(configuration.GetConnectionString("LocalConnection")));
builder.Services.AddScoped<IDataRepository<User>, UserRepository>();
builder.Services.AddScoped<IDataRepository<TodoItem>, TodoItemRepository>();
builder.Services.AddScoped<IDatabaseScope, DatabaseScope>();
builder.Services.AddScoped<IService<UserCreateUpdateDTO, UserDTO, User>, UserService>();
builder.Services.AddScoped<ITodoItemService<TodoItemSelectionListDTO, TodoItemCreateUpdateDTO, TodoItemDTO, TodoItem>, TodoItemService>();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "TodoApi", Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TodoApi v1"));
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();