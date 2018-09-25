using System;
using ConsoleTheater.Models;

namespace ConsoleTheater
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Theater theater = new Theater("My theater");
      System.Console.WriteLine($"Welcome to {theater.Name}, Wanna buy the theater out? (Y/N)");
      string input = Console.ReadLine();
      if (input.ToUpper() == "Y")
      {
        Console.WriteLine("That was a test dumb dumb. chill. Here's a list of things more in your league. Press anything to continue..");
        Console.ReadLine();
      }
      theater.Initialize();
      Movie titanic = new Movie("Titanic");
      Movie topgun = new Movie("Topgun");
      Movie lotr = new Movie("Lord of The Rings");
      Movie ironman = new Movie("Iron Man");
      theater.AddRoom(titanic, 80);
      theater.AddRoom(topgun, 80);
      theater.AddRoom(lotr, 80);
      theater.AddRoom(ironman, 80);
      theater.AddShowTime("8:00", 0);
      theater.AddShowTime("10:00", 0);
      theater.AddShowTime("8:00", 1);
      theater.AddShowTime("10:00", 1);
      theater.AddShowTime("1:00", 1);
      theater.AddShowTime("5:00", 2);
      theater.AddShowTime("8:00", 3);
      theater.AddShowTime("10:00", 3);
      theater.AddShowTime("1:00", 3);
      theater.AddShowTime("3:00", 3);
      theater.PrintMovies();
      Console.WriteLine(@" ");
      Console.Write("Hurry up.. ");
      string moviechoice = Console.ReadLine();
      Ticket titanic = new Ticket()
    }
  }
}
