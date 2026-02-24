using GNW_Bazaar.Core.Interface;
using GNW_Bazaar.Core.Interface.Clients;
using GNW_Bazaar.Core.Interface.Services;
using GNW_Bazaar.Core.Mappers.Dto;
using GNW_Bazaar.Core.Mappers.Entity;
using GNW_Bazaar.Core.Services;
using GNW_Bazzar.Dto;
using GNW_Bazzar.Entity;
using GNW_Bazzar.Infra.Clients;
using GNW_Bazzar.Infra.Settings;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IValidationClient, ValidationClient>();

builder.Services.AddScoped<IConfigurationSettings, ConfigurationSettings>();

builder.Services.AddScoped<IMasterDataService<ClientDto>, ClientService>();
builder.Services.AddScoped<IMasterDataClient<Client>, ClientClient>();
builder.Services.AddScoped<IMapper<ClientDto, Client>, ClientMapper>();
builder.Services.AddScoped<IMapper<Client, ClientDto>, ClientDtoMapper>();

builder.Services.AddScoped<ISponsorService, SponsorService>();
builder.Services.AddScoped<IMasterDataClient<Sponsor>, SponsorClient>();
builder.Services.AddScoped<IMapper<Sponsor, SponsorDto>, SponsorDtoMapper>();
builder.Services.AddScoped<IMapper<SponsorDto, Sponsor>, SponsorMapper>();

builder.Services.AddDbContext<GNW_BazaarDbContext>(Options =>
{
    Options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:SecurityKey"])),
            ValidateIssuer = false,
            ValidateAudience = false,
            ValidateLifetime = true,

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
