namespace SGE.UI.Web.Models
{
  public class SGEDatabaseSettings : ISGEDatabaseSettings
  {
    public string SGECollectionName { get; set; }
    public string ConnectionString { get; set; }
    public string DatabaseName { get; set; }
  }

  public interface ISGEDatabaseSettings
  {
    string SGECollectionName { get; set; }
    string ConnectionString { get; set; }
    string DatabaseName { get; set; }
  }
}
