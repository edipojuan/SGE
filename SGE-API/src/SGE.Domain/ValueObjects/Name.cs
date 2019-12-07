using SGE.Infrastructure.Core;

namespace SGE.Domain.ValueObjects
{
  public class Name : ValueObject<Name>
  {
    private readonly string _value;

    public Name(string name)
    {
      _value = name.Trim();
    }

    public static implicit operator string(Name name)
    {
      return name._value;
    }

    public static implicit operator Name(string value)
    {
      return new Name(value);
    }

    public bool Contains(string texto) => _value.Contains(texto);
  }
}