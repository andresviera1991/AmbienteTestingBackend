using Confluent.Kafka;
using MGP.Notifications.API.Helper;
using MGP.Notifications.Application.Consumers;
using MGP.Notifications.Domain.interfaces;
using MGP.Notifications.Domain.Services;
using MGP.Notifications.Persistance.Data.Tables;
using MGP.Notifications.Persistance.Interface;
using MGP.Notifications.Persistance;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MGP.Notifications.API.Controllers.Swagger;
using System.Reflection;
using MGP.Notifications.CrossCutting.MessagesManager;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using MGP.Notifications.Domain.HUB;

namespace MGP.Notifications.API
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddTransient<INotificationsService, NotificationsService>();
            builder.Services.AddTransient<INotificationsRepository, NotificationsRepository>();

            builder.Services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
                cfg.RegisterServicesFromAssembly(Assembly.Load("MGP.Notifications.Application"));
            });

            builder.Services.AddDbContext<MyDbContext>(opt =>
            {
                opt.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            builder.Services.AddSingleton<IConsumer<Ignore, string>>(provider =>
            {
                var config = new ConsumerConfig
                {
                    BootstrapServers = "localhost:9092",
                    GroupId = "ticket-consumer-group",
                    AutoOffsetReset = AutoOffsetReset.Earliest
                };
                return new ConsumerBuilder<Ignore, string>(config).Build();
            });

            builder.Services.AddHostedService<NotificationsConsumer>();
            builder.Services.AddSignalR();
            builder.Services.AddControllers();
            builder.Services.AddSwaggerConfig();

            var corsConfig = "AllowSpecificOrigin";

            builder.Services.AddCors(options =>
            {
                options.AddPolicy(corsConfig, policy =>
                {
                    policy
                        .WithOrigins("http://localhost:3000")
                        .AllowCredentials()
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });
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
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Notifications API V1");
                c.SwaggerEndpoint("/swagger/v2/swagger.json", "Notifications API V2");
                c.RoutePrefix = string.Empty;
            });

            app.MapHub<NotificationHub>("/notifications");
            app.MapControllers();
            app.Run();
        }
    }
}