using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace raspiapiproj
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .AddCommandLine(args)
                .Build();

            var host = new WebHostBuilder()
                       .UseKestrel()
                       .UseUrls("http://*:6000;https://localhost:6001") 
                       .UseContentRoot(Directory.GetCurrentDirectory())
                       .UseIISIntegration()
                       .UseStartup<Startup>()
                       .UseConfiguration(configuration)
                       .Build();

            host.Run();
        }
    }
}
