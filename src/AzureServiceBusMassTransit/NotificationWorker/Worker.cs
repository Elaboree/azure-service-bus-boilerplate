using MassTransit;
using Microsoft.Extensions.Hosting;
using NotificationWorker.Contracts;
using System.Threading;
using System.Threading.Tasks;

namespace NotificationWorker;
public class Worker : BackgroundService
{
    private readonly IBus bus;

    public Worker(IBus bus)
    {
        this.bus = bus;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            await bus.Publish(message: new Notification
            {
                Message = "A new message created by worker and sending"
            }, stoppingToken);

            await Task.Delay(10000, stoppingToken);
        }
    }
}
