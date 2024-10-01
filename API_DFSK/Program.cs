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
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

//builder.Services.AddSwaggerGen(); 

//Configurar Autenticacion de swagger
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
    // Configuración de seguridad para JWT
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Por favor ingrese el token JWT con el prefijo 'Bearer '",
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
    });
});

//Ignorar Objetos repetitivos
builder.Services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

//DbContexts
builder.Services.AddDbContext<DfskContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DFSK")), ServiceLifetime.Transient);
builder.Services.AddDbContext<ConcesionarioDfskContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConcesionarioDFSK")), ServiceLifetime.Transient);

//repositorys
builder.Services.AddScoped<IArticulosRepository, ArticulosRepository>();
builder.Services.AddScoped<ISolicitudesRepository, SolicitudesRepository>();
builder.Services.AddScoped<IUsuariosRepository, UsuariosRepository>();
builder.Services.AddScoped<IRepuestosRepository, RepuestosRepository>();
builder.Services.AddScoped<IEstadoRepository, EstadoRepository>();
builder.Services.AddScoped<IVehiculoRepository, VehiculoRepository>();
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
app.UseCors("AllowAnyOrigin");
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();
