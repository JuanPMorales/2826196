using Microsoft.EntityFrameworkCore;
using TiendaOnline.API.Data;

var builder = WebApplication.CreateBuilder(args);

// Agregar el servicio de DbContext con SQL Server
builder.Services.AddDbContext<TiendaDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("comoyoquiera")));

// Agregar servicios para controladores
builder.Services.AddControllers();

// Habilitar Swagger para la documentación de la API
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configurar el middleware para Swagger en entorno de desarrollo
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();
app.Run();

