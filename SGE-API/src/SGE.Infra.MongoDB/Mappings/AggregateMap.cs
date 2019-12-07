using System.Linq;
using System.Reflection;
using SGE.Infrastructure.Entities;
using SGE.Infrastructure.Mapping;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.IdGenerators;

namespace SGE.Infra.MongoDB.Mappings
{
  public class AggregateMap : IMap
  {
    public void Configure()
    {
      BsonClassMap.RegisterClassMap<Aggregate>(map =>
      {
        map.SetDiscriminator("aggregate");
        map.SetIsRootClass(true);
        map.MapIdProperty(e => e.AggregateId).SetIdGenerator(new GuidGenerator());
        map.AutoMap();

        var entities = Assembly
                  .GetAssembly(typeof(SGE.Domain.Foo))
                  .GetTypes()
                  .Where(x => x.BaseType == typeof(Aggregate))
                  .ToList();

        entities.ForEach(map.AddKnownType);
      });
    }
  }
}