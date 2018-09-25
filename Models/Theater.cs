using System;
using System.Collections.Generic;

namespace ConsoleTheater.Models
{
  public class Theater
  {
    public string Name { get; private set; }
    public List<Movie> Movies { get; set; }
    public List<Concession> Concessions { get; set; }
    public List<Room> Rooms { get; private set; }
    public void Initialize()
    {
      Concessions.Add(new Concession("popcorn", 9));
      Concessions.Add(new Concession("soda", 6));

    }
    public void AddRoom(Movie movie, int seats)
    {
      Rooms.Add(new Room(movie, seats));
    }
    public void AddShowTime(string showtime, int roomIndex)
    {
      Rooms[roomIndex].AddShowtime(showtime);
    }
    public void PrintMovies()
    {
      for (int i = 0; i < Rooms.Count; i++)
      {
        Console.WriteLine($@"
{i + 1}. {Rooms[i].Movie.Title}
Showtimes:");
        Rooms[i].PrintShowtimes();
      }
    }
    public Theater(string name)
    {
      Name = name;
      // Movies = new List<Movie>();
      Concessions = new List<Concession>();
      Rooms = new List<Room>();
    }
  }
}