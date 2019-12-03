namespace SGE.UI.Web.Models
{
  public class SGEDatabaseSettings : ISGEDatabaseSettings
  {
    public string EventosCollectionName { get; set; }
    public string Database { get; set; }
    public string Host { get; set; }
    public int Port { get; set; }
    public string User { get; set; }
    public string Password { get; set; }
    public string ConnectionString
    {
      get
      {
        if (string.IsNullOrEmpty(User) || string.IsNullOrEmpty(Password))
          return $@"mongodb://{Host}:{Port}";

        return $@"mongodb://{User}:{Password}@{Host}:{Port}";
      }
    }
  }

  public interface ISGEDatabaseSettings
  {
    string EventosCollectionName { get; set; }
    string Database { get; set; }
    string Host { get; set; }
    int Port { get; set; }
    string User { get; set; }
    string Password { get; set; }
    string ConnectionString { get; }
  }
}
