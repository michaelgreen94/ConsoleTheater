using System;
using ConsoleTheater.Models;

namespace ConsoleTheater
{
  class Program
  {
    static void Main(string[] args)
    {
      Theater theater = new Theater("My theater");
      theater.Initialize();
      Movie titanic = new Movie("Titanic");
      theater.AddRoom(titanic, 100);
      theater.AddShowTime("12:00", 0);
      theater.PrintMovies();
    }
  }
}
