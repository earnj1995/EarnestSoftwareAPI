using EarnestsWebApi.DB;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngularApp", policy =>
    {
        policy.WithOrigins("https://cloudfrontend.azurewebsites.net")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});
builder.Services.AddDbContextPool<EarnestSoftwareContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("UAT")));
    builder.Services.AddScoped<EarnestsWebApi.DAL.DAL>();
var app = builder.Build();

// Configure the HTTP request pipeline.

    app.UseSwagger();
    app.UseSwaggerUI();


app.UseHttpsRedirection();

app.MapControllers();

app.Run();

