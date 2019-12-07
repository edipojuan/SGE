using SGE.Infrastructure.Mapping;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;
using System;
using System.Linq;
using System.Reflection;

namespace MongoDB.Extensions
{
  public static class ServiceCollectionExtensions
  {
    public static void MongoDb(this IServiceCollection services, IConfiguration configuration)
    {
      var connectionString = configuration.GetConnectionString("MongoUrl");
      var url = new MongoUrlBuilder(connectionString) { GuidRepresentation = GuidRepresentation.Standard };

      services.AddSingleton<IMongoClient>(client => new MongoClient(url.ToMongoUrl()));

      var pack = new ConventionPack
            {
                new CamelCaseElementNameConvention(),
                new LookupIdGeneratorConvention(),
                new IgnoreExtraElementsConvention(true)
            };

      ConventionRegistry.Register("camelCase", pack, t => true);

      foreach (var mapping in Assembly.GetExecutingAssembly().GetTypes().Where(t => t.GetInterfaces().Contains(typeof(IMap))))
      {
        var map = (IMap)Activator.CreateInstance(mapping);
        map.Configure();
      }
    }
  }
}