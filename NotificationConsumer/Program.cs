using MassTransit;
using Microsoft.Extensions.Hosting;
using NotificationConsumer;

var builder = Host.CreateDefaultBuilder(args);

builder.ConfigureServices((hostContext, services) =>
{
    services.AddMassTransit(busConfigurator =>
    {
        busConfigurator.AddConsumer<NotificationCreatedConsumer>();
        busConfigurator.UsingRabbitMq((context, busFactoryConfigurator) =>
        {
            busFactoryConfigurator.Host("localhost", h => { });
            busFactoryConfigurator.ConfigureEndpoints(context);
        });

        
    });
});

var app = builder.Build();

app.Run();