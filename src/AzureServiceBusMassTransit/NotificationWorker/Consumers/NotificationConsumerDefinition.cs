namespace NotificationWorker.Consumers;
using MassTransit;

public class NotificationConsumerDefinition : ConsumerDefinition<NotificationConsumer>
{
    protected override void ConfigureConsumer(IReceiveEndpointConfigurator endpointConfigurator, IConsumerConfigurator<NotificationConsumer> consumerConfigurator)
    {
        endpointConfigurator.UseMessageRetry(r => r.Intervals(500, 1000));
    }
}