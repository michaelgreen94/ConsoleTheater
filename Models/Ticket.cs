using ConsoleTheater.Interfaces;

namespace ConsoleTheater.Models
{
  public class Ticket : IPurchaseable
  {
    public string Time { get; set; }
    public Movie Movie { get; set; }
    public decimal Price { get; set; }
    public string Type { get; set; }
    public Ticket(string time, Movie movie, decimal price)
    {
      Time = time;
      Movie = movie;
      Price = price;
      Type = "Ticket";
    }

    public void printname()
    {
      System.Console.WriteLine($"Purchase of {Movie} for {Price}");
    }
  }
}