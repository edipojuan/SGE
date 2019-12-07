using System.Threading.Tasks;
using Autofac;
using SGE.Infrastructure.CommandPattern.Dispatchers;
using SGE.Infrastructure.CommandPattern.Handlers;

namespace SGE.UI.Web.Setup
{
  public class CommandDispatcherSetup : CommandDispatcher
  {
    private readonly ILifetimeScope _scope;

    public CommandDispatcherSetup(ILifetimeScope scope)
    {
      _scope = scope;
    }

    protected override async Task RouteAsync<TCommand>(TCommand command)
    {
      var handler = _scope.Resolve<ICommandHandler<TCommand>>();
      await handler.ExecuteAsync(command);
    }
  }
}