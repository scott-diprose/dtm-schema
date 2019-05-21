/*
https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/polymorphism
https://www.google.com/search?q=c%23+polymorphism+with+interfaces&rlz=1C1GCEA_enAU825AU825&oq=c%23+polymorphism+with+in
https://www.tutorialspoint.com/csharp/csharp_polymorphism.htm
*/
namespace DPMetadata
{
  public interface IDataItem
  {
    string ColumnName { get; set; }
    string DataItemType { get; }
    IDataType DataType { get; set; }
  }

  public interface IDataColumn: IDataItem {}

  public interface IDataCalculation: IDataItem
  {
    string language { get; set; }
    string code { get; set; }
  }
}
