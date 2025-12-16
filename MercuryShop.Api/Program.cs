using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

using MercuryShop.Application.Interfaces;
using MercuryShop.Infrastructure.Data;
using MercuryShop.Infrastructure.Repositories;
using MercuryShop.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer(); //Endpoint explorer para Swagger
builder.Services.AddSwaggerGen(); //Visualizador Swagger

builder.Services.AddDbContext<MercuryShopDb>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection"); //Lee los datos de la conexión, definidos en appsettings.json

    options.UseMySql(
        connectionString,
        ServerVersion.AutoDetect(connectionString) //Detecta la version de base de datos que se esta usando 
    );
}); // Conexion a MySQL

builder.Services.AddScoped<IUserRepository, UserRepository>(); // () indica que es metodo, <> Son los tipos, cuando se pida IU va a entregar la instancia UserRep...
builder.Services.AddScoped<IPasswordHasher, PasswordHasher>();
builder.Services.AddScoped<IJwtService, JwtService>();


var jwtKey = builder.Configuration["Jwt:Key"];

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(jwtKey!)
        )
    };
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
