using SGE.Domain.ValueObjects;
using SGE.Infrastructure.Core;
using SGE.Infrastructure.Entities;
using System;

namespace SGE.Domain.Aggregates
{
  public class Palestra : Aggregate
  {
    public Palestra() : base("palestras") { }

    public string Name { get; set; }

    public Palestra(Guid aggregateId, string name)
    {
      AggregateId = aggregateId;
      Name = new Name(name);
    }

    public void Editar(string name)
    {
      Name = new Name(name);
    }

    public class NaoEncontradaException : BusinessException
    {
      public NaoEncontradaException() : base("A palestra não foi encontrada.") { }
    }
  }
}