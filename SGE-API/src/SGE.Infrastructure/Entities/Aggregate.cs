using System;

namespace SGE.Infrastructure.Entities
{
  public abstract class Aggregate
  {
    internal string Collection { get; }

    protected Aggregate(string collection)
    {
      Collection = collection;
    }
    protected Aggregate()
    {

    }

    public Guid AggregateId { get; set; }
    public bool Ativo { get; set; } = true;
    public void Inativar() => Ativo = !Ativo;
  }
}