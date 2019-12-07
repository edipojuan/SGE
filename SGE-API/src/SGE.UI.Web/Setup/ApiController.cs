using SGE.Infrastructure.CommandPattern.Dispatchers;
using SGE.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using SGE.UI.Web.Filters;

namespace SGE.UI.Web.Setup
{
  [ExceptionActionFilter]
  public class ApiController : Controller
  {
    protected readonly ICommandDispatcher Dispatcher;
    protected readonly IUnitOfWork UnitOfWork;

    public ApiController(ICommandDispatcher dispatcher, IUnitOfWork unitOfWork)
    {
      Dispatcher = dispatcher;
      UnitOfWork = unitOfWork;
    }
  }
}