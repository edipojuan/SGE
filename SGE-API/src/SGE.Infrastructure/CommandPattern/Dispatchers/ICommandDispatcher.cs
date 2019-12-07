using System.Threading.Tasks;
using SGE.Infrastructure.CommandPattern.Intentions;

namespace SGE.Infrastructure.CommandPattern.Dispatchers
{
  public interface ICommandDispatcher
  {
    Task DispatchAsync<TCommand>(TCommand command) where TCommand : ICommand;
  }
}