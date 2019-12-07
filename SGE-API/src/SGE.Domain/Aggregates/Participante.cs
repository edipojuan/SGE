using System;
using System.Collections.Generic;
using System.Linq;
using SGE.Domain.Entities;
using SGE.Infrastructure.Core;
using SGE.Infrastructure.Entities;

namespace SGE.Domain.Aggregates
{
  public class Participante : Aggregate
  {
    public Participante() : base("participantes") { }

    public string Name { get; set; }

    public Participante(Guid aggregateId, string name)
    {
      AggregateId = aggregateId;
      Name = name;
    }

    public void Editar(string name)
    {
      Name = name;
    }

    public class NaoEncontradoException : BusinessException
    {
      public NaoEncontradoException() : base("O Participante não foi encontrado.") { }
    }
  }
}