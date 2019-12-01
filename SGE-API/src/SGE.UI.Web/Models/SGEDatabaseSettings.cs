namespace SGE.UI.Web.Models
{
  public class SGEDatabaseSettings : ISGEDatabaseSettings
  {
    public string EventosCollectionName { get; set; }
    public string ConnectionString { get; set; }
    public string DatabaseName { get; set; }
  }

  public interface ISGEDatabaseSettings
  {
    string EventosCollectionName { get; set; }
    string ConnectionString { get; set; }
    string DatabaseName { get; set; }
  }
}
