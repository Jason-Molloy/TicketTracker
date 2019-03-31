using System;
using TicketTracker.Project.Models;

namespace TicketTracker.Project
{
  public class App
  {
    public TicketLog Log { get; set; }

    public bool UsingTicketTracker { get; set; }
    public void Run()
    {
      while (UsingTicketTracker)
      {
        Console.Clear();
        Log.PrintTickets();
        System.Console.WriteLine("What do you want to do? (C)reate, (Q)uit, or enter a number to view Ticket Details");
        string input = Console.ReadLine().ToLower();
        RunCommand(input);
      }
    }

    private void RunCommand(string input)
    {
      switch (input)
      {
        case "c":
          Log.CreateTicket();
          break;
        case "q":
          UsingTicketTracker = false;
          return;
        default:
          CheckType(input);
          break;
      }
      System.Console.WriteLine("\nPress any key to continue");
      System.Console.ReadLine();
    }

    private void CheckType(string input)
    {
      if (!Int32.TryParse(input, out int num))
      {
        System.Console.WriteLine("Invalid Command");
        return;
      }
      Log.ViewDetails(num);
    }
    public App()
    {
      Log = new TicketLog();
      UsingTicketTracker = true;
    }
  }
}