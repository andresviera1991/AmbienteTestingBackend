using Confluent.Kafka;
using MGP.Audit.API.Controllers.Swagger;
using MGP.Audit.API.Helper;
using MGP.Audit.Application.Consumers;
using MGP.Audit.Application.UseCase.V1;
using MGP.Audit.CrossCutting.MessagesManager;
using MGP.Audit.Persistance.Data.Tables;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Reflection;
namespace GatewayMGP.Audit;
public static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddApplication();
        builder.Services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            cfg.RegisterServicesFromAssembly(Assembly.Load("MGP.Audit.Application"));
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

        builder.Services.AddHostedService<AuditConsumer>();
        builder.Services.AddControllers();
        builder.Services.AddSwaggerConfig();

        var corsConfig = "AuditMGP";

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
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "Audit API V1");
            c.SwaggerEndpoint("/swagger/v2/swagger.json", "Audit API V2");
            c.RoutePrefix = string.Empty;
        });

        app.MapControllers();
        app.Run();

    }
}