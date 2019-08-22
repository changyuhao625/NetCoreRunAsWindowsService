namespace NetCoreRunAsWindowsService
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Extensions.Hosting;

    public class JobService : IHostedService
    {
        public Task StartAsync(CancellationToken cancellationToken)
        {
            return ServiceMain();
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Service Stop: Press Any Key!");
            Console.ReadLine();
            return Task.CompletedTask;
        }

        private Task ServiceMain()
        {
            Console.WriteLine("Service Start");
            return Task.CompletedTask;
        }
    }
}