using Ocelot.Middleware;
using MGP.Discapacidad.API.Helper.JWT;
using MGP.ApiGateway.OcelotMiddleware;
namespace MGP.ApiGateway
{
    public static class Program
    {
        public async static Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddJwtAuthentication(builder.Configuration);
            builder.Services.AddOcelotConfiguration(builder.Configuration, builder.Environment);

            builder.Services.AddSwaggerForOcelot(builder.Configuration);

            var corsConfig = "ApiGatewayMGP";

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

            app.UsePathBase("/gateway");
            app.UseStaticFiles();

            app.UseSwaggerForOcelotUI(opt =>
            {
                opt.PathToSwaggerGenerator = "/swagger/docs";
            });

            app.UseHttpsRedirection();
            app.UseCors(corsConfig);

            app.UseAuthentication();

            app.UseAuthorization();

            app.MapControllers();

            await app.UseOcelot();

            await app.RunAsync();
        }
    }
}
