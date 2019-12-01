using System;

using SGE.UI.Web.Models;
using SGE.UI.Web.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;

namespace SGE.UI.Web
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
      services.AddCors(options =>
          {
            options.AddPolicy("AllowSpecificOrigin",
                    item => item.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
          });

      services.Configure<SGEDatabaseSettings>(
          Configuration.GetSection(nameof(SGEDatabaseSettings)));

      services.AddSingleton<ISGEDatabaseSettings>(sp =>
          sp.GetRequiredService<IOptions<SGEDatabaseSettings>>().Value);

      services.AddSingleton<EventoService>();

      services.AddMvc()
              .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

      services.AddSwaggerGen(c =>
      {
        c.SwaggerDoc("v1", new OpenApiInfo
        {
          Version = "v1",
          Title = "SGE API",
          Description = "SGE API Swagger",
          Contact = new OpenApiContact
          {
            Name = "Édipo Juan",
            Email = "edipojs@gmail.com",
            Url = new Uri("http://www.edipojuan.com.br"),
          },
          License = new OpenApiLicense
          {
            Name = "Use under MIT",
            Url = new Uri("https://github.com/edipojuan/SGE/blob/master/LICENSE"),
          }
        });
      });

    }

    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      app.UseSwagger();

      app.UseSwaggerUI(c =>
      {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
        c.RoutePrefix = string.Empty;
      });

      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
      else
      {
        app.UseHsts();
      }

      app.UseCors("AllowSpecificOrigin");

      app.UseMvc();
    }
  }
}
