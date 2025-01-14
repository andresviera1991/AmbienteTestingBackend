using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using MGP.Authentication.Domain.Helper;
using MGP.Authentication.Persistance.Data.Tables;
using MGP.Authentication.CrossCutting.MessagesManager;
using MGP.Authentication.API.Helpers;
using MGP.Authentication.API.Controllers.Swagger;
using Confluent.Kafka;
using MGP.Authentication.Application.UseCase.V1;

namespace MGP.Authentication.Api
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var configuration = builder.Configuration;

            builder.Services.AddApplication();

            builder.Services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
                cfg.RegisterServicesFromAssembly(Assembly.Load("MGP.Authentication.Application"));
            });

            builder.Services.AddDbContext<MyDbContext>(opt =>
            {
                opt.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            builder.Services.AddSingleton<IProducer<Null, string>>(provider =>
            {
                var config = new ProducerConfig
                {
                    BootstrapServers = "localhost:9092",
                    Acks = Acks.All
                };
                return new ProducerBuilder<Null, string>(config).Build();
            });

            builder.Services.Configure<JwtAccessTokenSettings>(configuration.GetSection("AccessToken"));
            builder.Services.Configure<JwtRefreshTokenSettings>(configuration.GetSection("RefreshToken")); 
            builder.Services.Configure<JwtEmailTokenSettings>(configuration.GetSection("EmailToken"));
            builder.Services.AddControllers();
            builder.Services.AddSwaggerConfig();
            builder.Services.AddAutoMapper(typeof(AutoMapping));

            builder.Services.ConfigureMessageManager();

            var corsConfig = "AuthenticationMGP";

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

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "MGP.Authentication API V1");
                c.RoutePrefix = string.Empty;
            });

            app.MapControllers();
            app.Run();

        }
    }
}