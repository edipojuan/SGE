using System.Threading.Tasks;
using SGE.Infrastructure.CommandPattern.Intentions;

namespace SGE.Infrastructure.CommandPattern.Dispatchers
{
  public abstract class CommandDispatcher : ICommandDispatcher
  {
    public Task DispatchAsync<TCommand>(TCommand command) where TCommand : ICommand
    {
      return RouteAsync(command);
    }

    protected abstract Task RouteAsync<TCommand>(TCommand command) where TCommand : ICommand;
  }
}