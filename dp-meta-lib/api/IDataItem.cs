/*
https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/polymorphism
https://www.google.com/search?q=c%23+polymorphism+with+interfaces&rlz=1C1GCEA_enAU825AU825&oq=c%23+polymorphism+with+in
https://www.tutorialspoint.com/csharp/csharp_polymorphism.htm
*/
namespace DPMetaLib
{
  public interface IDataItem
  {
    string ColumnName { get; set; }
    string DataType { get; set; }
  }

  public interface IDataColumn: IDataItem
  {
    // string ColumnName { get; set; }
    // string DataType { get; set; }
    int IsNullable { get; set; }
    int MaxLength { get; set; }
    int Precision { get; set; }
  }

  public interface IDataCalculation: IDataItem
  {
    // string ColumnName { get; set; }
    // string DataType { get; set; }
    string language { get; set; }
    string code { get; set; }
  }
}
