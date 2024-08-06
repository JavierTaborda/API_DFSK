using System.Text.Json.Serialization;
using API_DFSK.Context;
using API_DFSK.Interfaces.ConcesionarioDFSK;
using API_DFSK.Interfaces.DFSK;
using API_DFSK.Repository.ConcesionarioDFSK;
using API_DFSK.Repository.DFSK;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers().AddJsonOptions(x =>x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
builder.Services.AddDbContext<DfskContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DFSKsecret")), ServiceLifetime.Transient);
builder.Services.AddDbContext<ConcesionarioDfskContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConcesionarioDFSKSecret")), ServiceLifetime.Transient);
builder.Services.AddScoped<IArticulosRepository, ArticulosRepository>();
builder.Services.AddScoped<ISolicitudesRepository, SolicitudesRepository>();

builder.Services.AddAutoMapper(typeof(Program));
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
