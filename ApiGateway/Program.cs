using GNW_Bazaar.Core.Interface.Services;
using GNW_Bazaar.Core.Services;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ITokenService, TokenService>();

builder.Configuration.AddJsonFile("Ocelot.json", optional: false, reloadOnChange: true);

builder.Services.AddAuthentication("JwtAuth")
    .AddJwtBearer("JwtAuth", options =>
    {
        options.TokenValidationParameters = TokenService.GetValidationParameters();
    });

builder.Services.AddOcelot(builder.Configuration);

var app = builder.Build();

app.UseRouting();

app.UseAuthentication(); 
app.UseAuthorization();

app.MapControllers();

await app.UseOcelot();

app.Run();
