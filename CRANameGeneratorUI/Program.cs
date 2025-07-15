using CRANameGeneratorLib.DataAccessImplementations;
using CRANameGeneratorUI.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using System;
using System.Windows.Forms;
using CRANameGeneratorLib.Abstractions;
using CRANameGeneratorLib.NameGenerableImplementations;
using System.IO;

namespace CRANameGeneratorUI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);            

            IHostBuilder hostBuilder = CreateHostBuilder();
            IHost host = hostBuilder.Build();            
            
            host.Run();          
        }

        /// <summary>
        /// Create the configurations files.
        /// </summary>
        /// <param name="builder">The configuration builder.</param>
        static void BuildConfig(IConfigurationBuilder builder)
        {
            builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json", optional: true)
                .AddEnvironmentVariables();
        }

        /// <summary>
        /// Create all the application context. Add here the injected dependencies.
        /// </summary>
        /// <returns>The HostBuilder.</returns>
        public static IHostBuilder CreateHostBuilder()
        {
            var configBuilder = new ConfigurationBuilder();
            BuildConfig(configBuilder);

            return Host.CreateDefaultBuilder()
                .UseSerilog((_, configuration) => 
                {
                    configuration
                      .ReadFrom.Configuration(configBuilder.Build())
                      .Enrich.FromLogContext()
                      .WriteTo.Console(outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] [{SourceContext}] {Message:lj}{NewLine}{Exception}")
                      .WriteTo.File(@"./logs/.log", outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] [{SourceContext}] {Message:lj}{NewLine}{Exception}", retainedFileCountLimit: 31, rollingInterval: RollingInterval.Day);
                })

                .ConfigureServices((_, services) => 
                {
                    services.AddSingleton<FmHome>();
                    services.AddSingleton<IDataAccess, DataAccessFromCSV>();
                    services.AddSingleton<INameGenerable, StandardNameGenerator>();
                    services.AddHostedService<FrameService>();
                });
        }
    }
}
