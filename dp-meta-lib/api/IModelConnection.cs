namespace DPMetadata
{
  /*
  Purpose: Stores the details for connecting to a data model in order to either extract or load data.

  TODO: Abstract how to connect to a data model. Even though initially only implement using ODBC connections.
  */
  public interface IModelConnection
  {
    string Name { get; }

    string Description { get; }

    string OdbcConnString { get; }

    IModelConnection NewOdbcConnection(string name, string description, string odbcConnString);
  }
}
