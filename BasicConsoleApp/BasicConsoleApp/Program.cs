using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("BasicConsoleApp.Tests")]
namespace BasicConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();
            BuildConfig(builder);
        }

        static void BuildConfig(IConfigurationBuilder builder)
        {
            var host = Host.CreateDefaultBuilder()
                //.ConfigureServices((context, services) =>
                //{
                //    //services.AddTransient<ClassName>();
                //})
                //// Add app settings
                .Build();

            var svc = ActivatorUtilities.CreateInstance<Startup>(host.Services);
            svc.Run();
        }
    }
}