using MassTransitpublishConsumer.Domain.Enums;

namespace MassTransitpublishConsumer.Domain.Interfaces.Notification;

public interface INotificationCreated
{
    public DateTime NotificationDate { get;}
    public string NotificationMessage { get;}
    public NotificationType NotificationType { get;}
}
