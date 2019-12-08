using Autofac;
using Autofac.Extensions.DependencyInjection;
using SGE.Commands;
using SGE.Infrastructure.CommandPattern.Dispatchers;
using SGE.Infrastructure.CommandPattern.Handlers;
using SGE.Infrastructure.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SGE.Infra.MongoDB.Data;
using SGE.Infra.MongoDB.DI;
using MongoDB.Extensions;
using Swashbuckle.AspNetCore.SwaggerUI;
using System;
using System.Globalization;
using SGE.UI.Web.Configurations;
using SGE.UI.Web.Setup;

namespace SGE.UI.Web
{
  public class Startup
  {
    public IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IServiceProvider ConfigureServices(IServiceCollection services)
    {
      services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

      services.AddCors();
      services.AddOptions();

      services.AddScoped<IHttpContextAccessor, HttpContextAccessor>();
      services.AddScoped<IMongoContext, MongoContext>();
      services.AddScoped<IUnitOfWork, UnitOfWork>();

      services.MongoDb(Configuration);

      Register(services);

      var builder = new ContainerBuilder();

      builder.Populate(services);

      builder.RegisterType<CommandDispatcherSetup>().As<ICommandDispatcher>().InstancePerLifetimeScope();
      builder.RegisterAssemblyTypes(typeof(Foo).Assembly).AsClosedTypesOf(typeof(ICommandHandler<>)).AsImplementedInterfaces();

      var container = builder.Build();

      return new AutofacServiceProvider(container);
    }

    private static void Register(IServiceCollection services)
    {
      Swagger.Configure(services);
      MongoModule.Load(services);
    }

    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      app.UseCors(builder =>
      {
        builder.AllowAnyHeader();
        builder.AllowAnyOrigin();
        builder.AllowAnyMethod();
      });

      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      var supportedCultures = new[] { new CultureInfo("pt-BR") };

      app.UseMvcWithDefaultRoute();
      app.UseMvc();

      app.UseSwaggerUI(c =>
      {
        c.SwaggerEndpoint("swagger/v1/swagger.json", "API");
        c.RoutePrefix = string.Empty;
        c.DocExpansion(DocExpansion.None);
      });

      app.UseSwagger();
    }
  }
}
