using System.Collections.Generic;

namespace DPMetadata
{
  /*
  Purpose: Stores the details for connecting to a data model in order to either extract or load data.

  TODO: Abstract how to connect to a data model. Even though initially only implement using ODBC connections.
  */
  public interface IDataStore
  {
    string ConnectionKey { get; }
    string OdbcConnString { get; } // optional (may be stored in the staging/production environments, and so not required (if don't require model metadata from the physical data store))

    Model DataModel { get; } // optional
  }
}
