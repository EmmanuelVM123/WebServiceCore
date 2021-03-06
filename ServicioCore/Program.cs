using Microsoft.EntityFrameworkCore;
using ServicioData;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Se agrega kla conexi?n a SQL
builder.Services.AddDbContext<DataContext>(options => { options.UseSqlServer(builder.Configuration.GetConnectionString("ServicioConetxJOSN")); });
//______________fin________________

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
