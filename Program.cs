using Microsoft.EntityFrameworkCore; //importo EF
using api_ejercicio.DataAccess; //importo carpeta del context

var builder = WebApplication.CreateBuilder(args);

//accedo a la conexión setteada en mi config
const string CONNECTIONNAME = "openBootCampDB";
var connectionString = builder.Configuration.GetConnectionString(CONNECTIONNAME);

//agrego context
builder.Services.AddDbContext<OpenBCContextDB>(options => options.UseSqlServer(connectionString));

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
