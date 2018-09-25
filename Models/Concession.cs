using ConsoleTheater.Interfaces;

namespace ConsoleTheater.Models
{
  public class Concession : IPurchaseable
  {
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Type { get; set; }
    public Concession(string name, decimal price)
    {
      Name = name;
      Price = price;
      Type = "Concession";
    }

    public void printname()
    {
      System.Console.WriteLine($"Purchase of {Name} for {Price}");
    }
  }
}