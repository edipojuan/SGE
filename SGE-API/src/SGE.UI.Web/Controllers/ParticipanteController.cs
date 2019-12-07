using SGE.Commands.ParticipanteCommands;
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
  [Route("v1/participante")]
  public class ParticipanteController : ApiController
  {
    private readonly IParticipanteFinder _finder;

    public ParticipanteController(ICommandDispatcher dispatcher, IUnitOfWork unitOfWork, IParticipanteFinder finder) : base(dispatcher, unitOfWork)
    {
      _finder = finder;
    }

    [HttpPost("")]
    public async Task<IActionResult> CriarAsync([FromBody]ParticipanteDto dto)
    {
      var aggregateId = Guid.NewGuid();

      var command = new CriarParticipanteCommand(aggregateId, dto.Name);

      await Dispatcher.DispatchAsync(command);
      await UnitOfWork.CommitAsync();

      return Ok(await _finder.GetByAsync(aggregateId));
    }

    [HttpGet("{aggregateId:guid}")]
    public async Task<IActionResult> ObterPorAsync(Guid aggregateId)
    {
      return Ok(await _finder.GetByAsync(aggregateId));
    }

    [HttpGet("{aggregateId:guid}/editar")]
    public async Task<IActionResult> EditarAsync(Guid aggregateId, [FromBody]ParticipanteDto dto)
    {
      var command = new EditarParticipanteCommand(aggregateId, dto.Name);

      await Dispatcher.DispatchAsync(command);
      await UnitOfWork.CommitAsync();

      return Ok(await _finder.GetByAsync(aggregateId));
    }

    [HttpGet("consulta-simples", Name = "ConsultaSimplesParticipante")]
    public async Task<IActionResult> ObterPorAsync([FromQuery] Pagination pagination)
    {
      return Ok(await _finder.GetByAsync(pagination));
    }

    [HttpGet("consulta-rapida", Name = "ConsultaRapidaParticipante")]
    public async Task<IActionResult> ObterPorAsync(string texto, [FromQuery] Pagination pagination)
    {
      return Ok(await _finder.GetByAsync(texto, pagination));
    }
  }
}