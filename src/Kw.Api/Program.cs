using Kw.Api.Services;
using Kw.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddTransient<IUserService, SqlUserService>();

builder.Services.AddDbContextPool<KwDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Kw.ConnStr"));
});

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            policy.WithOrigins("*");
        });
});

var app = builder.Build();

app.UseHttpsRedirection();

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
