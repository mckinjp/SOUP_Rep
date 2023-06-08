using Microsoft.Extensions.Hosting;

//This is a test

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .Build();

host.Run();
