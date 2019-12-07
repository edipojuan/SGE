using SGE.Domain.ValueObjects;
using SGE.Infrastructure.Entities;
using System;
using SGE.Infrastructure.Core;

namespace SGE.Domain.Aggregates
{
  public class Palestrante : Aggregate
  {
    public Palestrante() : base("palestrantes") { }

    public string Name { get; set; }

    public Palestrante(Guid aggregateId, string name)
    {
      AggregateId = aggregateId;
      Name = new Name(name);
    }

    public void Editar(string name)
    {
      Name = new Name(name);
    }

    public class NaoEncontradoException : BusinessException
    {
      public NaoEncontradoException() : base("O Palestrante não foi encontrado.") { }
    }
  }
}