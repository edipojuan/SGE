using Microsoft.Extensions.DependencyInjection;

namespace SGE.Infra.CrossCutting.IoC
{
  public class NativeInjectorBootStrapper
  {
    public static void RegisterServices(IServiceCollection services)
    {
      //   services.AddSingleton<ISGEDatabaseSettings>(sp =>
      //       sp.GetRequiredService<IOptions<SGEDatabaseSettings>>().Value);

      //   services.AddSingleton<EventoService>();
    }
  }
}