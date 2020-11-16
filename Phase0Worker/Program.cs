using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RedisCache;
using Serilog;
using Serilog.Events;

namespace Phase0Worker
{
    class Program
    {
        static async Task Main(string[] args) 
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                .Enrich.FromLogContext()
                .WriteTo.Console()
                .WriteTo.File(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Phase0Worker.log"), rollingInterval: RollingInterval.Day)
                .CreateLogger();

            await CreateHostBuilder(args)
                .Build()
                .RunAsync();

        }

        static IHostBuilder CreateHostBuilder(string[] args) =>
            Host
                .CreateDefaultBuilder(args)
                .UseSystemd()
                .ConfigureServices((hostedContext, service) => 
                {
                    service.AddHostedService<WorkerHostedService>();

                    service.AddSingleton<ICache, RedisCache.Cache>();
                })
                .UseSerilog();
    }
}
