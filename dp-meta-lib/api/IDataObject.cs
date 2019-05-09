using System.Collections.Generic;

namespace DPMetaLib
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
