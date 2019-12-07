using SGE.Commands.PalestraCommands;
using SGE.Domain.Finders;
using SGE.Infrastructure.CommandPattern.Dispatchers;
using SGE.Infrastructure.Data;
using SGE.Infrastructure.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using SGE.UI.Web.Models;
using SGE.UI.Web.Setup;

namespace SGE.UI.Web.Controllers
{
  [Route("v1/palestra")]
  public class PalestraController : ApiController
  {
    private readonly IPalestraFinder _finder;

    public PalestraController(ICommandDispatcher dispatcher, IUnitOfWork unitOfWork, IPalestraFinder finder) : base(dispatcher, unitOfWork)
    {
      _finder = finder;
    }

    [HttpPost("")]
    public async Task<IActionResult> CriarAsync([FromBody]PalestraDto dto)
    {
      var aggregateId = Guid.NewGuid();

      var command = new CriarPalestraCommand(aggregateId, dto.Name);

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
    public async Task<IActionResult> EditarAsync(Guid aggregateId, [FromBody]PalestraDto dto)
    {
      var command = new EditarPalestraCommand(aggregateId, dto.Name);

      await Dispatcher.DispatchAsync(command);
      await UnitOfWork.CommitAsync();

      return Ok(await _finder.GetByAsync(aggregateId));
    }

    [HttpGet("consulta-simples", Name = "ConsultaSimplesPalestra")]
    public async Task<IActionResult> ObterPorAsync([FromQuery] Pagination pagination)
    {
      return Ok(await _finder.GetByAsync(pagination));
    }

    [HttpGet("consulta-rapida", Name = "ConsultaRapidaPalestra")]
    public async Task<IActionResult> ObterPorAsync(string texto, [FromQuery] Pagination pagination)
    {
      return Ok(await _finder.GetByAsync(texto, pagination));
    }
  }
}