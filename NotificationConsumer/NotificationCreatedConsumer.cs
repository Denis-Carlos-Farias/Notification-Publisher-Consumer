using MassTransit;
using MassTransitpublishConsumer.Domain.Interfaces.Notification;
using System.Text.Json;

namespace NotificationConsumer;

public class NotificationCreatedConsumer : IConsumer<INotificationCreated>
{
    public async Task Consume(ConsumeContext<INotificationCreated> context)
    {
        var serializedMessage = JsonSerializer.Serialize(context.Message, new JsonSerializerOptions { });

        Console.WriteLine($"NotificationCreated event consumed. Message: {serializedMessage}");
    }
}