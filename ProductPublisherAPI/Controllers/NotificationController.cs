using MassTransit;
using MassTransitpublishConsumer.Domain.Interfaces.Notification;
using Microsoft.AspNetCore.Mvc;
using ProductPublisherAPI.Models;

namespace ProductPublisherAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class NotificationController(IPublishEndpoint publishEndpoint) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Notify(NotificationDto notificationDto)
    {
        await publishEndpoint.Publish<INotificationCreated>(new
        {
            notificationDto.NotificationDate,
            notificationDto.NotificationMessage,
            notificationDto.NotificationType
        });

        return Ok();
    }
}
