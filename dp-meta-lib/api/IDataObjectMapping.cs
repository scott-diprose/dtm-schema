using System.Collections.Generic;

namespace DPMetadata
{
  public interface IDataObjectMapping
  {
    /***
    Purpose: The parent object collection, which includes source and target connections details.
    ***/
    IModelMapping ModelMapping
    {
      get;
    }

    /***
    Purpose: Either object or code
    ***/
    IDataObject Source
    // ICodeObject Source
    {
      get;
    }

    IDataObject Target
    {
      get;
    }

    List<IDataItemMapping> MappedDataItems
    {
      get;
    }


    /*** Extension properties ***/

    string PackageName
    {
      get;
    }

    string TargetConnectionName
    {
      get;
    }

    string SourceConnectionName
    {
      get;
    }

    string ExtractSQL
    {
      get;
    }

    string EndDatingSQL
    {
      get;
    }
  }
}
