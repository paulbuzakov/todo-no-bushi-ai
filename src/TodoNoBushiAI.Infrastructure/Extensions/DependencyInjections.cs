using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Telegram.Bot;

namespace TodoNoBushiAI.Infrastructure.Extensions;

public static class DependencyInjections
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        configuration.Validate();

        services.AddSingleton<ITelegramBotClient>(new TelegramBotClient(configuration["TelegramBot:Token"]!));

        return services;
    }

    private static void Validate(this IConfiguration configuration)
    {
        if (string.IsNullOrWhiteSpace(configuration["TelegramBot:Token"]))
        {
            throw new ArgumentException("TelegramBot:Token is not configured.");
        }
    }
}
