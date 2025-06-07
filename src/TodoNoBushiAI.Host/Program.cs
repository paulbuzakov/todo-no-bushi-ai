using TodoNoBushiAI.Host;
using TodoNoBushiAI.Infrastructure.Extensions;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddInfrastructure(builder.Configuration)
    .AddHostedService<Worker>();

var host = builder.Build();
host.Run();
