namespace Company.Consumers
{
    using MassTransit;

    public class NotificationConsumerConsumerDefinition :
        ConsumerDefinition<NotificationConsumerConsumer>
    {
        protected override void ConfigureConsumer(IReceiveEndpointConfigurator endpointConfigurator, IConsumerConfigurator<NotificationConsumerConsumer> consumerConfigurator)
        {
            endpointConfigurator.UseMessageRetry(r => r.Intervals(500, 1000));
        }
    }
}