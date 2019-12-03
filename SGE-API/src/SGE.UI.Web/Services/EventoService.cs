using SGE.UI.Web.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace SGE.UI.Web.Services
{
  public class EventoService
  {
    private readonly IMongoCollection<Evento> _evento;

    public EventoService(ISGEDatabaseSettings settings)
    {
      var client = new MongoClient(settings.ConnectionString);
      var database = client.GetDatabase(settings.Database);

      _evento = database.GetCollection<Evento>(settings.EventosCollectionName);
    }

    public List<Evento> Get() =>
        _evento.Find(evento => true).ToList();

    public Evento Get(string id) =>
        _evento.Find<Evento>(evento => evento.Id == id).FirstOrDefault();

    public Evento Create(Evento evento)
    {
      _evento.InsertOne(evento);
      return evento;
    }

    public void Update(string id, Evento eventoIn) =>
        _evento.ReplaceOne(evento => evento.Id == id, eventoIn);

    public void Remove(Evento eventoIn) =>
        _evento.DeleteOne(evento => evento.Id == eventoIn.Id);

    public void Remove(string id) =>
        _evento.DeleteOne(evento => evento.Id == id);
  }
}
