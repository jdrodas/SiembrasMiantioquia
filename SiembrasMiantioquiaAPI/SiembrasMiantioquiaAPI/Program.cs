using SiembrasMiantioquiaAPI.Models;
using SiembrasMiantioquiaAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddJsonOptions(
        options => options.JsonSerializerOptions.PropertyNamingPolicy = null);

builder.Services.Configure<SiembrasMiantioquiaDatabaseSettings>(
    builder.Configuration.GetSection("SiembrasMiantioquiaDatabase"));

builder.Services.AddSingleton<SiembrasService>();
//builder.Services.AddSingleton<RegionesService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();