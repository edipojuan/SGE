using SGE.UI.Web.Models;
using SGE.UI.Web.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SGE.UI.Web.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class EventoController : ControllerBase
  {
    private readonly EventoService _eventoService;

    public EventoController(EventoService eventoService)
    {
      _eventoService = eventoService;
    }

    [HttpGet]
    public ActionResult<List<Evento>> Get() =>
        _eventoService.Get();

    [HttpGet("{id:length(24)}", Name = "GetEvento")]
    public ActionResult<Evento> Get(string id)
    {
      var evento = _eventoService.Get(id);

      if (evento == null)
      {
        return NotFound();
      }

      return evento;
    }

    [HttpPost]
    public ActionResult<Evento> Create(Evento evento)
    {
      _eventoService.Create(evento);

      return CreatedAtRoute("GetEvento", new { id = evento.Id.ToString() }, evento);
    }

    [HttpPut("{id:length(24)}")]
    public IActionResult Update(string id, Evento eventoIn)
    {
      var evento = _eventoService.Get(id);

      if (evento == null)
      {
        return NotFound();
      }

      _eventoService.Update(id, eventoIn);

      return NoContent();
    }

    [HttpDelete("{id:length(24)}")]
    public IActionResult Delete(string id)
    {
      var evento = _eventoService.Get(id);

      if (evento == null)
      {
        return NotFound();
      }

      _eventoService.Remove(evento.Id);

      return NoContent();
    }
  }
}
