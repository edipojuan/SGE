using System;

namespace SGE.Infrastructure.CommandPattern.Intentions
{
  public abstract class Command : ICommand
  {
    public Guid AggregateId { get; set; }

    protected Command(Guid aggregateId)
    {
      AggregateId = aggregateId;
    }
  }
}