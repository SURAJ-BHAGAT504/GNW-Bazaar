using GNW_Bazaar.Core.Interface;
using GNW_Bazaar.Core.Interface.Clients;
using GNW_Bazaar.Core.Interface.Services;
using GNW_Bazaar.Core.Mappers.Dto;
using GNW_Bazaar.Core.Mappers.Entity;
using GNW_Bazaar.Core.Services;
using GNW_Bazzar.Dto;
using GNW_Bazzar.Entity;
using GNW_Bazzar.Infra.Clients;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = TokenService.GetValidationParameters();
    });

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IValidationClient, ValidationClient>();

builder.Services.AddScoped<IMasterDataService<HealthCareCategoryDto>, HealthCareCategoryService>();
builder.Services.AddScoped<IMasterDataClient<HealthCareCategory>, HealthCareCategoryClient>();
builder.Services.AddScoped<IMapper<HealthCareCategoryDto, HealthCareCategory>, HealthCareCategoryMapper>();
builder.Services.AddScoped<IMapper<HealthCareCategory, HealthCareCategoryDto>, HealthCareCategoryDtoMapper>();

builder.Services.AddDbContext<GNW_BazaarDbContext>(Options =>
{
    Options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseAuthentication();

app.MapControllers();

app.Run();
