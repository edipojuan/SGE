namespace SGE.Domain.Entities
{
  public class Categoria
  {
    public int Id { get; set; }
    public string Name { get; set; }

    public Categoria()
    {

    }

    public Categoria(int id)
    {
      Id = id;
      Name = ((ECategoria)id).ToString();
    }
  }
}