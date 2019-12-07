using SGE.Commands.PalestranteCommands;
using SGE.Domain.Finders;
using SGE.Infrastructure.CommandPattern.Dispatchers;
using SGE.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using SGE.Infrastructure.Entities;
using SGE.UI.Web.Models;
using SGE.UI.Web.Setup;

namespace SGE.UI.Web.Controllers
{
  [Route("v1/palestrante")]
  public class PalestranteController : ApiController
  {
    private readonly IPalestranteFinder _finder;

    public PalestranteController(ICommandDispatcher dispatcher, IUnitOfWork unitOfWork, IPalestranteFinder finder) : base(dispatcher, unitOfWork)
    {
      _finder = finder;
    }

    [HttpPost("")]
    public async Task<IActionResult> CriarAsync([FromBody]PalestranteDto dto)
    {
      var aggregateId = Guid.NewGuid();

      var command = new CriarPalestranteCommand(aggregateId, dto.Name);

      await Dispatcher.DispatchAsync(command);
      await UnitOfWork.CommitAsync();

      return Ok(await _finder.GetByAsync(aggregateId));
    }

    [HttpGet("{aggregateId:guid}")]
    public async Task<IActionResult> ObterPorAsync(Guid aggregateId)
    {
      return Ok(await _finder.GetByAsync(aggregateId));
    }

    [HttpPut("{aggregateId:guid}/editar")]
    public async Task<IActionResult> EditarAsync(Guid aggregateId, [FromBody]PalestranteDto dto)
    {
      var command = new EditarPalestranteCommand(aggregateId, dto.Name);

      await Dispatcher.DispatchAsync(command);
      await UnitOfWork.CommitAsync();

      return Ok(await _finder.GetByAsync(aggregateId));
    }

    [HttpGet("consulta-simples", Name = "ConsultaSimplesPalestrante")]
    public async Task<IActionResult> ObterPorAsync([FromQuery] Pagination pagination)
    {
      return Ok(await _finder.GetByAsync(pagination));
    }

    [HttpGet("consulta-rapida", Name = "ConsultaRapidaPalestrante")]
    public async Task<IActionResult> ObterPorAsync(string texto, [FromQuery] Pagination pagination)
    {
      return Ok(await _finder.GetByAsync(texto, pagination));
    }
  }
}