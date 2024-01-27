using E_Commerce.Repository;
using E_Commerce.Services.DataTransfer;
using E_Commerce.Services.HttpCalls;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;
// Add services to the container.
services.AddControllers();
services.AddRouting(config => config.LowercaseUrls = true);
string corsConfig = "CORS_CONFIG";
services.AddCors(op =>
    op.AddPolicy(name: corsConfig, builder => {
        builder
                .WithOrigins("http://localhost:4200")
                .AllowAnyMethod()
                .WithHeaders("Content-Type", "Authorization")
                .AllowCredentials(); })
    );

services.AddDbContext<CommercialContext>(op =>
    op.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

services.AddTransient<IHttpService, HttpService>();
services.AddTransient<IFactory, DTOFactory>();

services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStaticFiles();
app.UseRouting();

app.UseCors(corsConfig);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();
