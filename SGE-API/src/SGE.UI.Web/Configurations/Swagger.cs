using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.IO;
using System.Reflection;

namespace SGE.UI.Web.Configurations
{
  public static class Swagger
  {
    public static void Configure(IServiceCollection services)
    {
      services.AddSwaggerGen(c =>
      {
        // var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
        // var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

        // c.IncludeXmlComments(xmlPath);
        c.DescribeAllEnumsAsStrings();

        c.SwaggerDoc("v1", new Info
        {
          Title = "API",
          Version = "v1",
        });
      });
    }
  }
}
