﻿using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace SGE.UI.Web
{
  public class Program
  {
    public static void Main(string[] args)
    {
      BuildWebHost(args).Run();
    }

    public static IWebHost BuildWebHost(string[] args) =>
        WebHost
            .CreateDefaultBuilder(args)
            .UseStartup<Startup>()
            .ConfigureServices(s => s.AddAutofac())
            .Build();
  }
}
