using CloudinaryDotNet;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using SMConsulting.API;
using SMConsulting.API.Middlewares;
using SMConsulting.BL;
using SMConsulting.Core.Entities;
using SMConsulting.DAL;
using SMConsulting.DAL.Context;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


var _corsAllowAny = "allowAnyPolicy";


builder.Services.Configure<CloudinarySettings>(
    builder.Configuration.GetSection("CloudinarySettings"));


builder.Services.AddCors(options =>
{
    options.AddPolicy(_corsAllowAny, policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "SmConsulting API",
        Version = "v1"
    });

    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Scheme = "bearer",
        BearerFormat = "JWT",
        Description = "Paste only JWT token"
    });

    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            Array.Empty<string>()
        }
    });
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

    if (File.Exists(xmlPath))
        options.IncludeXmlComments(xmlPath);
});

builder.Services.AddAutoMapper(cfg => { }, typeof(Program).Assembly);
builder.Services.AddServices();
builder.Services.AddRepositories();
builder.Services.AddFluentValidation();

builder.Services.AddJwt(builder.Configuration);
builder.Services.AddAuthorization();

builder.Services.AddDbContext<SmDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("MsSql"),
        sqlOptions =>
        {
            sqlOptions.EnableRetryOnFailure();
        }));
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler =
            System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
    });
var app = builder.Build();

//app.UseMiddleware<ExceptionMiddleware>();

//if (app.Environment.IsDevelopment())
//{
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.ConfigObject.AdditionalItems.Add("persistAuthorization", "true");
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "SmConsulting API v1");
    c.DocExpansion(Swashbuckle.AspNetCore.SwaggerUI.DocExpansion.None);
    c.DisplayRequestDuration();
});
//}
app.UseStaticFiles();
app.UseHttpsRedirection();

app.UseCors(_corsAllowAny);

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
