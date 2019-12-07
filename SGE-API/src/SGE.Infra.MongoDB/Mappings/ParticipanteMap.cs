using SGE.Domain.Aggregates;
using SGE.Infrastructure.Mapping;
using MongoDB.Bson.Serialization;

namespace SGE.Infra.MongoDB.Mappings
{
  public class ParticipanteMap : IMap
  {
    public void Configure()
    {
      BsonClassMap.RegisterClassMap<Participante>(map =>
      {
        map.SetDiscriminator("participante");
        map.AutoMap();
      });
    }
  }
}