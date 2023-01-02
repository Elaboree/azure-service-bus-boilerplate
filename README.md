# Azure service bus and Masstransit usage implementation and configurations  :eye_speech_bubble:

  For more flexibility when brokering messaging between client and server with asynchronous operations along with structured first-in, first-out (FIFO) messaging and publish/subscribe capabilitiesGet more flexibility when brokering messaging between client and server with asynchronous operations along with structured first-in, first-out (FIFO) messaging and publish/subscribe capabilities.
  
  MassTransit fully supports Azure Service Bus, including many of the advanced features and capabilities.

### Built With

* NET6
* [AzureServiceBus](https://azure.microsoft.com/en-us/products/service-bus/)
* [MassTransit](https://masstransit-project.com/)

<br/>


<!-- Keynotes -->
## Configuration insights :footprints:

- Producing operations manages in  `Worker.cs` via HostedService
- To simplify project have one contract and one information `Contracts/Notification`
- Notification consumer consumes `Notification Event`
- `Program.cs`includes MassTransit and azure configurations, with the assembly provider we can add all assembly consumers `x.AddConsumers(entryAssembly);`
- In the `UsingAzureServiceBus` configuration `Host` method waits azure host address. We can pass this information inline or our config file



:warning:
**The Azure Service Bus transport only supports Standard and Premium tiers of the Microsoft Azure Service Bus service. Premium tier is recommended for production environments. See Performance section below.**
