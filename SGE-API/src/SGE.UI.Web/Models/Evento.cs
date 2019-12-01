using System;

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SGE.UI.Web.Models
{
  public class Evento
  {
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string Name { get; set; }
    public string Author { get; set; }
    public DateTime Date { get; set; }
    public string Description { get; set; }
  }
}
