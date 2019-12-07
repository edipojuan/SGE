using System.Threading.Tasks;
using SGE.Infrastructure.CommandPattern.Intentions;

namespace SGE.Infrastructure.CommandPattern.Handlers
{
  public interface ICommandHandler<in TCommand> where TCommand : ICommand
  {
    Task ExecuteAsync(TCommand command);
  }
}