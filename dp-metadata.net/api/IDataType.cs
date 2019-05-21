namespace DPMetadata
{
  public interface IDataType
  {
    string BaseDataType { get; set; }
    int IsNullable { get; set; }
    int MaxLength { get; set; }
    int Precision { get; set; }
    string FullDescription { get; }
  }
}
