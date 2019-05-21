namespace DPMetadata
{
  public interface IDataItemMapping
  {
    /*** either or... ***/
    IDataItem SourceDataItem
    {
      get;
    }

    IDataCalculation CalculatedDataItem
    {
      get;
    }

    /*** ***/

    IDataColumn TargetDataItem
    {
      get;
    }


    /*** Extension properties ***/

    // bool MultiActiveKeyIndicator
    // {
    //   get;
    // }
  }
}
