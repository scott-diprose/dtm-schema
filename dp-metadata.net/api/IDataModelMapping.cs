using System.Collections.Generic;

namespace DPMetadata
{
  /*
  Purpose: Details how data elements relate between two different data models. Including
            any required translations and transformations.
  */
  public interface IDataModelMapping
  {
    string MappingTitle { get; }
    string MappingDescription { get; }
    IDataStore SourceModel { get; }
    IDataStore TargetModel { get; }
    List<IDataObjectMapping> MappedObjects { get; set; }
    List<IDataObjectMapping> IgnoredObjects { get; set; } // optional; is the objects explicitly flagged to be ignored (preserved if mappings "refreshed" from updated data store schemas)

    IDataModelMapping NewModelMapping(string name, string description, IDataStore SourceModel, IDataStore TargetModel);
  }
}
