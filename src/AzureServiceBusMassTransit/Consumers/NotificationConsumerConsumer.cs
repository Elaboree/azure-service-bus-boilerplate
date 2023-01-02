namespace Company.Consumers
{
    using System.Threading.Tasks;
    using MassTransit;
    using Contracts;

    public class NotificationConsumerConsumer :
        IConsumer<NotificationConsumer>
    {
        public Task Consume(ConsumeContext<NotificationConsumer> context)
        {
            return Task.CompletedTask;
        }
    }
}