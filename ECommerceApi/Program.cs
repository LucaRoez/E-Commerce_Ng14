using ECommerce.Repository;
using ECommerce.Services.DataTransfer;
using ECommerce.Services.HttpCalls;

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
        builder.WithOrigins("https//localhost:4400");
    })
);

services.AddTransient<IRepository, CommercialContext>();
services.AddTransient<IHttpService, HttpService>();
services.AddTransient<IFactory, DTOFactory>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
