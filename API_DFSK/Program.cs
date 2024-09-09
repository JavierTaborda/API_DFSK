using System.Text;
using System.Text.Json.Serialization;
using API_DFSK.Context;
using API_DFSK.Custom;
using API_DFSK.Interfaces.Authentication;
using API_DFSK.Interfaces.ConcesionarioDFSK;
using API_DFSK.Interfaces.DFSK;
using API_DFSK.Repository.Authentication;
using API_DFSK.Repository.ConcesionarioDFSK;
using API_DFSK.Repository.DFSK;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

//DbContexts
builder.Services.AddDbContext<DfskContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DFSKsecret")), ServiceLifetime.Transient);
builder.Services.AddDbContext<ConcesionarioDfskContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConcesionarioDFSKSecret")), ServiceLifetime.Transient);

//repositorys
builder.Services.AddScoped<IArticulosRepository, ArticulosRepository>();
builder.Services.AddScoped<ISolicitudesRepository, SolicitudesRepository>();
builder.Services.AddScoped<ICrearTXTRepository, CrearTXTRepository>();
builder.Services.AddScoped<IAuth, AuthRepository>();

//jwt
builder.Services.AddSingleton<Utilities>();//generar tokens y encriptar
builder.Services.AddAuthentication(config =>
{
    config.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    config.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(config =>
{
    config.RequireHttpsMetadata = false;
    config.SaveToken = true;
    config.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = true,
        ClockSkew=TimeSpan.Zero,
        IssuerSigningKey = new SymmetricSecurityKey
        (Encoding.UTF8.GetBytes(builder.Configuration["Jwt:key"]!))
    };

    });

//Services
builder.Services.AddAutoMapper(typeof(Program));

//cors
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAnyOrigin", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.UseCors("AllowAnyOrigin");
app.Run();
