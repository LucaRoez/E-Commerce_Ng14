using ECommerceApi.Repository;
using ECommerceApi.Services.DataTransfer;
using ECommerceApi.Services.HttpCalls;
using ECommerceApi.Services.Utilities;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;
// Add services to the container.

services.AddControllers();
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();
services.AddRouting(config => config.LowercaseUrls = true);
string corsConfig = "CORS_CONFIG";
services.AddCors(op =>
    op.AddPolicy(name: corsConfig, builder => {
        builder.WithOrigins("http://localhost:4200", "https://localhost:4200")
               .AllowAnyMethod()
               .AllowAnyHeader();
    })
);

services.AddTransient<IRepository, CommercialContext>();
services.AddTransient<IHttpService, HttpService>();
services.AddTransient<IFactory, DTOFactory>();
services.AddTransient<ResponseManager>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(corsConfig);

app.UseAuthorization();

app.MapControllers();

app.Run();
