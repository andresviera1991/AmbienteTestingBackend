using MGP.Discapacidad.API.Helper;
using MGP.Discapacidad.API.Controllers.Swagger;
using MGP.Discapacidad.API.Hubs;
using Microsoft.AspNetCore.Builder;
using MGP.Discapacidad.Client.Interface.Backoffice;
using MGP.Discapacidad.Application.UseCase.V1;
using Refit;
using Microsoft.Extensions.DependencyInjection;
using System;
using Microsoft.Extensions.Configuration;
using System.Reflection;
using MGP.Discapacidad.Persistance.Data.Tables;
using Microsoft.EntityFrameworkCore;
using Confluent.Kafka;
using MGP.Discapacidad.Application.Consumers;
using System.Linq;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.FileProviders;
using System.IO;
using MGP.Discapacidad.CrossCutting.MessagesManager;
using MGP.Discapacidad.Client.Interface.Authentication;
namespace GatewayMGP.Discapacidad;

public static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var configuration = builder.Configuration;

        builder.Services.AddApplication();

        builder.Services.AddRefitClient<IBackofficeApi>()
            .ConfigureHttpClient(c => c.BaseAddress = new Uri(configuration.GetValue<string>("BackofficeUri")))
            .SetHandlerLifetime(TimeSpan.FromMinutes(2));


        builder.Services.AddRefitClient<IAuthenticationApi>()
            .ConfigureHttpClient(c => c.BaseAddress = new Uri(configuration.GetValue<string>("AuthenticationUri")))
            .SetHandlerLifetime(TimeSpan.FromMinutes(2));

        builder.Services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            cfg.RegisterServicesFromAssembly(Assembly.Load("MGP.Discapacidad.Application"));
        });

        builder.Services.AddDbContext<MyDbContext>(opt =>
        {
            opt.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
        });
        builder.Services.AddTransient<IConsumer<Ignore, string>>(provider =>
        {
            var config = new ConsumerConfig
            {
                BootstrapServers = "localhost:9092",
                GroupId = "ticket-consumer-group",
                AutoOffsetReset = AutoOffsetReset.Earliest
            };
            return new ConsumerBuilder<Ignore, string>(config).Build();
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

        builder.Services.AddHostedService<TicketConsumer>();
        builder.Services.AddHostedService<AgentReturnsLeaveConsumer>();
        builder.Services.AddHostedService<UnassignTicketConsumer>();

        builder.Services.AddControllers();
        builder.Services.AddSwaggerConfig();

        var corsConfig = "AllowSpecificOrigin";

        builder.Services.AddCors(options =>
        {
            options.AddPolicy(corsConfig, policy =>
            {
                policy
                    .SetIsOriginAllowed(origin => new[] { "http://localhost:5173", "http://localhost:5175" }.Contains(origin))
                    .AllowCredentials()
                    .AllowAnyHeader()
                    .AllowAnyMethod();
            });
        });

        builder.Services.AddSignalR();

        builder.Services.AddAutoMapper(typeof(AutoMapping));
        builder.Services.AddHttpClient();

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

        //app.UseStaticFiles(new StaticFileOptions
        //{
        //    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "../files")),
        //    RequestPath = "/files"
        //});

        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "Discapacidad API V1");
            c.SwaggerEndpoint("/swagger/v2/swagger.json", "Discapacidad API V2");
            c.RoutePrefix = string.Empty;
        });
        app.MapHub<TicketChatHub>("/chat");

        app.MapControllers();
        app.Run();
    }
}