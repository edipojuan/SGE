using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Reflection;

namespace SGE.Infra.MongoDB.DI
{
  public static class MongoModule
  {
    public static void Load(IServiceCollection services)
    {
      var repositories = Assembly.GetAssembly(typeof(Foo)).GetTypes()
          .Where(t => t.Name.EndsWith("Repository"))
          .ToDictionary(i => i.GetInterfaces()[2], t => t);

      foreach (var repository in repositories)
      {
        services.AddTransient(repository.Key, repository.Value);
      }

      var finders = Assembly.GetAssembly(typeof(Foo)).GetTypes()
          .Where(t => t.Name.EndsWith("Finder"))
          .ToDictionary(i => i.GetInterfaces()[2], t => t);

      foreach (var finder in finders)
      {
        services.AddTransient(finder.Key, finder.Value);
      }
    }
  }
}