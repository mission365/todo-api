using Microsoft.EntityFrameworkCore;
using TodoApi.Data;
using TodoApi.Mappings;
using TodoApi.Middlewares;
using TodoApi.Repositories;

var builder = WebApplication.CreateBuilder(args);

// 1. Database Context
builder.Services.AddDbContext<TodoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// 2. Repository
builder.Services.AddScoped<ITodoRepository, TodoRepository>();

// 3. AutoMapper
builder.Services.AddAutoMapper(typeof(MappingProfile));

// 4. Controllers & Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// 5. Error Handling Middleware (সবার আগে)
app.UseMiddleware<GlobalExceptionMiddleware>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();