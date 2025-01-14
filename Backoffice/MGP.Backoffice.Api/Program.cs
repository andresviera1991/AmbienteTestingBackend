using MGP.Backoffice.Api.Helper;
using MGP.Backoffice.Persistence.Data.Tables;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Quartz;
using System.Reflection;
using MGP.Backoffice.API.Controllers.Swagger;
using MGP.Backoffice.Domain.Helper;
using MGP.Backoffice.CrossCutting.MessagesManager;
using MGP.Backoffice.Application.UseCase.V1.AgentVacationScheduledTask;
using System;
using Confluent.Kafka;
using MGP.Backoffice.Application.UseCase.V1;
namespace MGP.Backoffice.Auth;

public static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var configuration = builder.Configuration;
        builder.Services.AddApplication();


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

        builder.Services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            cfg.RegisterServicesFromAssembly(Assembly.Load("MGP.Backoffice.Application"));
        });

        IdentityConfiguration(builder);

        builder.Services.AddCors(setup =>
        {
            setup.AddPolicy("BackofficeMGP", x =>
            {
                x.WithOrigins(builder.Configuration.GetValue<string>("Origins"));

            });
        });

        builder.Services.Configure<JwtAccessTokenSettings>(configuration.GetSection("AccessToken"));
        builder.Services.Configure<JwtRefreshTokenSettings>(configuration.GetSection("RefreshToken"));

        builder.Services.AddControllers();
        builder.Services.AddSwaggerConfig();
        builder.Services.AddAutoMapper(typeof(AutoMapping));
        builder.Services.ConfigureMessageManager();

        builder.Services.AddQuartz(q =>
        {
            q.UseMicrosoftDependencyInjectionJobFactory();
        });

        builder.Services.AddQuartzHostedService(q => q.WaitForJobsToComplete = true);
        builder.Services.AddTransient<AgentVacationJob>();

        var app = builder.Build();

        app.UseCors("BackofficeMGP");

        app.UseHttpsRedirection();

        app.UseAuthentication();
        app.UseAuthorization();
        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "MGP.Backoffice API V1");
            c.RoutePrefix = string.Empty;
        });

        app.MapControllers();

        var scheduler = app.Services.GetRequiredService<ISchedulerFactory>().GetScheduler().Result;
        ConfigureJobs(app.Services, scheduler);

        app.Run();
    }

    private static void IdentityConfiguration(WebApplicationBuilder builder)
    {
        builder.Services.AddIdentity<User, Role>(opt =>
        {

            opt.Password.RequireDigit = true;
            opt.Password.RequireNonAlphanumeric = false;
            opt.Password.RequiredLength = 8;
            opt.Password.RequireUppercase = false;
            opt.SignIn.RequireConfirmedEmail = false;
            opt.Lockout.AllowedForNewUsers = true;
            opt.Lockout.MaxFailedAccessAttempts = 5;
        })
        .AddDefaultTokenProviders()
        .AddEntityFrameworkStores<MyDbContext>();
    }



    public static void ConfigureJobs(IServiceProvider serviceProvider, IScheduler scheduler)
    {
        var job = JobBuilder.Create<AgentVacationJob>()
            .WithIdentity("AgentVacationJob", "group1")
            .Build();

        var trigger = TriggerBuilder.Create()
            .WithIdentity("AgentVacationJobTrigger", "group1")
            .WithCronSchedule("0 * * ? * *")
            .Build();

        scheduler.ScheduleJob(job, trigger);
    }
}