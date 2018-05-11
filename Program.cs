﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace TTAServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            return WebHost.CreateDefaultBuilder()
                .UseStartup<Startup>()
                .Build();
        }
    }
}
