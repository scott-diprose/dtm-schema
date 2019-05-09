using System.Collections.Generic;

namespace DPMetaLib
{
  /*
  Purpose: Details how data elements relate between two different data models. Including
            the required translations and transformation logic.
  */
  public interface IModelMapping
  {
    string MappingTitle { get; }
    string MappingDescription { get; }
    IModelConnection SourceModel { get; }
    IModelConnection TargetModel { get; }
    List<IDataObjectMapping> MappedObjects { get; }
    List<IDataObjectMapping> IgnoredObjects { get; set; } // objects explicitly flagged to be ignored (preserved if mappings "refreshed" from updated data store schemas)

    IModelMapping NewModelMapping(string name, string description, IModelConnection SourceModel, IModelConnection TargetModel);
  }
}
