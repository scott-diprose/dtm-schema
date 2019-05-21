using System.Collections.Generic;

namespace DPMetadata
{
  /*
  Purpose: Identifies the location of the definitions for the canonical data model.

  TODO: Abstract how to connect to a various sources. Such as SQL create scripts, or metadata files, in file path, repository, etc.
  TODO: Research is best to separate Model and DataStore?
  */
  public interface IDataModel
  {
    string Name { get; }
    string Description { get; }
    string SchemaLocation { get; } // optional (Note that metadata could also be loaded from the physical connection (though unlikely to be the cononical source).)
    IDataStore PhysicalStore { get; }
    List<IDataObject> DataObjects { get; } // optional (may not be required for all processing tasks)

    IDataStore NewModel(string name, string description, string schemaLocation, string odbcConnString);
  }
}
