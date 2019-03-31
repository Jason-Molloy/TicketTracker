using System;
using TicketTracker.Project;

namespace ticketTracker
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Console.WriteLine("Welcome to Ticket Tracker\nPress any key to continue");
      Console.ReadLine();
      App app = new App();
      app.Run();
    }
  }
}
