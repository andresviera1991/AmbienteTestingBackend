using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace MGP.Audit.CrossCutting.MessagesManager
{
    public static class MessageManagerConfiguration
    {
        public static IServiceCollection ConfigureMessageManager(this IServiceCollection services)
        {
            services.AddSingleton<ErrorMessagesProvider>(provider =>
            {
                var folderPath = Path.Combine(AppContext.BaseDirectory, "ErrorCatalog");
                return new ErrorMessagesProvider(folderPath);
            });

            services.AddSingleton<MessageManager>();

            return services;
        }
    }
}
