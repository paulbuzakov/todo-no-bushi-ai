namespace TodoNoBushiAI.Infrastructure.Extensions;

public static class DependencyInjections
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSingleton<ITelegramBotClient>(new TelegramBotClient(configuration["TelegramBot:Token"]));

        return services;
    }
}
