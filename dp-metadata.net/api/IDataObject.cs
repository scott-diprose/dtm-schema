using System.Collections.Generic;

namespace DPMetadata
{
  public interface IDataObject
  {
    string SchemaName
    {
      get;
    }

    string ObjectName
    {
      get;
    }

    List<IDataColumn> Columns { get; set; }
  }
}
