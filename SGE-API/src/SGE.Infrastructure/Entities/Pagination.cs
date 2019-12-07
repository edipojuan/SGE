namespace SGE.Infrastructure.Entities
{
  public class Pagination
  {
    public int Skip { get; set; } = 1;
    public int Limit { get; set; } = 10;

    public Pagination()
    {

    }
  }
}