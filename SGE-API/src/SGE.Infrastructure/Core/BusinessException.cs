using System;

namespace SGE.Infrastructure.Core
{
  public abstract class BusinessException : ArgumentException
  {
    protected BusinessException(string message)
    {

    }

    public class Required : Exception
    {
      public Required(string message) : base($"O campo de \" {message} \" é obrigatório.") { }
    }
  }
}