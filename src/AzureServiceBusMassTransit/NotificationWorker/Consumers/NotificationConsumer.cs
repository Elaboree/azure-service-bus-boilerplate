namespace NotificationWorker.Consumers;
using System.Threading.Tasks;
using MassTransit;
using Microsoft.Extensions.Logging;
using NotificationWorker.Contracts;

public class NotificationConsumer : IConsumer<Notification>
{
    private readonly ILogger<NotificationConsumer> _logger;

    public NotificationConsumer(ILogger<NotificationConsumer> logger)
    {
        _logger = logger;
    }

    public Task Consume(ConsumeContext<Notification> context)
    {
        _logger.LogInformation(message: $"Consumed notification message is {context.Message.Message}");
        return Task.CompletedTask;
    }
}