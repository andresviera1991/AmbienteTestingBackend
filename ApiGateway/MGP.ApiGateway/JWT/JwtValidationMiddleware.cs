using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;

namespace MGP.Discapacidad.API.Helper.JWT
{
    public static class JwtMiddleware
    {
        public static IServiceCollection AddJwtAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            var jwtSettings = configuration.GetSection("AccessToken").Get<JwtSettings>();

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultSignOutScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = jwtSettings.Issuer,
                    ValidAudience = jwtSettings.Audience,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(jwtSettings.SecretKey)),
                    ClockSkew = TimeSpan.Zero
                };

                options.Events = new JwtBearerEvents
                {
                    OnMessageReceived = context =>
                    {
                        var token = context.Request.Headers["Authorization"].ToString();
                        if (!string.IsNullOrEmpty(token) && token.StartsWith("Bearer "))
                        {
                            context.Token = token["Bearer ".Length..].Trim();
                        }

                        return Task.CompletedTask;
                    },
                    OnTokenValidated = context =>
                    {
                        var claimsIdentity = context.Principal.Identity as ClaimsIdentity;

                        var userIdClaim = claimsIdentity?.FindFirst("UserId");
                        var name = claimsIdentity?.FindFirst("Name");
                        var agentIdClaim = claimsIdentity?.FindFirst("EmployeeId");
                        var userEmailClaim = claimsIdentity?.FindFirst("Email");
                        var roleClaim = claimsIdentity?.FindFirst("Role");
                        var roleIdClaim = claimsIdentity?.FindFirst("RoleId");
                        var areaClaim = claimsIdentity?.FindFirst("Area");
                        var areaIdClaim = claimsIdentity?.FindFirst("AreaId");
                        var isEmployeeClaim = claimsIdentity?.FindFirst("IsEmployee");
                        var isNeighborClaim = claimsIdentity?.FindFirst("IsNeighbor");

                        if (userIdClaim != null)
                        {
                            context.Request.Headers["UserId"] = userIdClaim.Value;
                        }
                        if (name != null)
                        {
                            context.Request.Headers["Name"] = name.Value;
                        }
                        if (agentIdClaim != null)
                        {
                            context.Request.Headers["EmployeeId"] = agentIdClaim.Value;
                        }
                        if (userEmailClaim != null)
                        {
                            context.Request.Headers["UserEmail"] = userEmailClaim.Value;
                        }
                        if (roleClaim != null)
                        {
                            context.Request.Headers["Role"] = roleClaim.Value;
                        }
                        if (roleIdClaim != null)
                        {
                            context.Request.Headers["RoleId"] = roleIdClaim.Value;
                        }
                        if (areaClaim != null)
                        {
                            context.Request.Headers["Area"] = areaClaim.Value;
                        }
                        if (areaIdClaim != null)
                        {
                            context.Request.Headers["AreaId"] = areaIdClaim.Value;
                        }
                        if (isEmployeeClaim != null)
                        {
                            context.Request.Headers["IsEmployee"] = isEmployeeClaim.Value;
                        }
                        if (isNeighborClaim != null)
                        {
                            context.Request.Headers["IsNeighbor"] = isNeighborClaim.Value;
                        }

                        context.Request.Headers.Remove("Authorization");
                        return Task.CompletedTask;
                    },

                    OnChallenge = context =>
                    {
                        if (!context.Response.HasStarted)
                        {
                            context.Response.StatusCode = 401;
                            context.Response.ContentType = "application/json";

                            context.Response.Headers.Append("Access-Control-Allow-Origin", new[] { "*" });
                            context.Response.Headers.Append("Access-Control-Allow-Headers", new[] { "Content-Type", "Authorization" });
                            context.Response.Headers.Append("Access-Control-Allow-Methods", new[] { "GET", "POST", "PUT", "DELETE", "OPTIONS" });

                            return Task.CompletedTask;
                        }

                        return Task.CompletedTask;
                    }
                };
            });

            return services;
        }
    }
}
