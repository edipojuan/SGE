using SGE.Domain.Aggregates;
using SGE.Infrastructure.Mapping;
using MongoDB.Bson.Serialization;

namespace SGE.Infra.MongoDB.Mappings
{
  public class PalestranteMap : IMap
  {
    public void Configure()
    {
      BsonClassMap.RegisterClassMap<Palestrante>(map =>
      {
        map.SetDiscriminator("palestrante");
        map.AutoMap();
      });
    }
  }
}