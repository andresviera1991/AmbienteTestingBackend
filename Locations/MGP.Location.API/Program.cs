using MGP.LocationAPI;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using MGP.Location.CrossCutting.MessagesManager;
using System;
using System.IO;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using MGP.Location.Persistance.Data.Tables;
using MGP.Location.Client.Interface;
using Refit;
using Asp.Versioning;
using MGP.Location.Application.UseCase.V1;

namespace GatewayMGP.Location
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var configuration = builder.Configuration;

            builder.Services.AddApplication(configuration);

            builder.Services.AddRefitClient<IGeoRefArApi>()
                .ConfigureHttpClient(c => c.BaseAddress = new Uri(configuration.GetValue<string>("IGeoRefArUri")))
                .SetHandlerLifetime(TimeSpan.FromMinutes(2));
            builder.Services.AddHttpClient();

            builder.Services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
                cfg.RegisterServicesFromAssembly(Assembly.Load("MGP.Location.Application"));
            });

            builder.Services.AddDbContext<MyDbContext>(opt =>
            {
                opt.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            builder.Services.AddApiVersioning(options =>
            {
                options.DefaultApiVersion = new ApiVersion(1, 0);
                options.AssumeDefaultVersionWhenUnspecified = true;
                options.ReportApiVersions = true;
                options.ApiVersionReader = ApiVersionReader.Combine(
                    new UrlSegmentApiVersionReader(),
                    new HeaderApiVersionReader("X-Api-Version")
                );
            }).AddApiExplorer(options =>
            {
                options.GroupNameFormat = "'v'VVV";
                options.SubstituteApiVersionInUrl = true;
            });

            builder.Services.AddControllers();

            var corsConfig = "LocationsMGP";

            builder.Services.AddCors(setup =>
            {
                setup.AddPolicy(corsConfig, x =>
                {
                    x.WithOrigins(builder.Configuration.GetValue<string>("Origins")!);
                    x.AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod();

                });
            });
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "MGP.Location API - V1",
                    Version = "v1.0",
                    Description = "Esta API permite obtener las provincias, departamentos y localidades de Argentina para utilizar en el sistema MGP.\n\n"
                });
             
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
                c.EnableAnnotations();
                c.UseAllOfToExtendReferenceSchemas();
            });

            builder.Services.AddAutoMapper(typeof(AutoMapping));

            builder.Services.ConfigureMessageManager();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseCors(corsConfig);
            app.UseRouting();
            app.UseAuthorization();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Location API v1");
                //c.SwaggerEndpoint("/swagger/v2/swagger.json", "Location API v2");
                c.RoutePrefix = string.Empty;
            });

            app.MapControllers();
            app.Run();

        }
    }
}