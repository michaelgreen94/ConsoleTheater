namespace ConsoleTheater.Interfaces
{
  public interface IPurchaseable
  {
    decimal Price { get; set; }
    string Type { get; set; }
    void printname();
  }
}