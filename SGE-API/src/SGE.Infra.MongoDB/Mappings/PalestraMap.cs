using SGE.Domain.Aggregates;
using SGE.Infrastructure.Mapping;
using MongoDB.Bson.Serialization;

namespace SGE.Infra.MongoDB.Mappings
{
  public class PalestraMap : IMap
  {
    public void Configure()
    {
      BsonClassMap.RegisterClassMap<Palestra>(map =>
      {
        map.SetDiscriminator("palestra");
        map.AutoMap();
      });
    }
  }
}