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

builder.Services.AddScoped<IMasterDataService<CategoryMasterDto>, CategoryMasterService>();
builder.Services.AddScoped<IMasterDataClient<CategoryMaster>, CategoryMasterClient>();
builder.Services.AddScoped<IMapper<CategoryMasterDto, CategoryMaster>, CategoryMasterMapper>();
builder.Services.AddScoped<IMapper<CategoryMaster, CategoryMasterDto>, CategoryMasterDtoMapper>();

builder.Services.AddScoped<IMasterDataService<HealthCareCategoryDto>, HealthCareCategoryService>();
builder.Services.AddScoped<IMasterDataClient<HealthCareCategory>, HealthCareCategoryClient>();
builder.Services.AddScoped<IMapper<HealthCareCategoryDto, HealthCareCategory>, HealthCareCategoryMapper>();
builder.Services.AddScoped<IMapper<HealthCareCategory, HealthCareCategoryDto>, HealthCareCategoryDtoMapper>();

builder.Services.AddScoped<IMasterDataService<UserDto>, UserService>();
builder.Services.AddScoped<IMasterDataClient<User>, UserClient>();
builder.Services.AddScoped<IMapper<User, UserDto>, UserDtoMapper>();
builder.Services.AddScoped<IMapper<UserDto, User>, UserMapper>();

builder.Services.AddScoped<IDoctorService, DoctorService>();
builder.Services.AddScoped<IDoctorClient, DoctorClient>();
builder.Services.AddScoped<IMapper<DoctorDto, Doctor>, DoctorMapper>();
builder.Services.AddScoped<IMapper<Doctor, DoctorDto>, DoctorDtoMapper>();

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

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular",
        policy => policy.WithOrigins("http://localhost:4200")
                        .AllowAnyMethod()
                        .AllowAnyHeader());
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAuthentication();
app.UseCors("AllowAngular");
app.UseAuthorization();

app.MapControllers();

app.Run();
