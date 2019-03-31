using System;
using System.Collections.Generic;
using ticketTracker.Project.Models;

namespace TicketTracker.Project.Models
{
  public class TicketLog
  {
    public List<Ticket> Log { get; set; }

    public void PrintTickets()
    {
      System.Console.WriteLine(@"       Active Tickets
____________________________ ");
      for (int i = 0; i < Log.Count; i++)
      {
        Ticket ticket = Log[i];
        System.Console.WriteLine($"{i + 1} {ticket.Title}");
      }
    }
    public TicketLog()
    {
      Log = new List<Ticket>()
      {
        new Ticket("Ticket tracker working?", "This is for the test")
      };
    }

    internal void CreateTicket()
    {
      System.Console.WriteLine("Please name your ticket:");
      string title = Console.ReadLine();
      System.Console.WriteLine("Please give your ticket a description:");
      string description = Console.ReadLine();
      Ticket newTicket = new Ticket(title, description);
      Log.Add(newTicket);
      Console.Clear();
      System.Console.WriteLine("Successfully added the ticket {0}", newTicket.Title);
    }
    internal void ViewDetails(int num)
    {
      Console.Clear();
      if (num > Log.Count || num < 1)
      {
        Console.Beep();
        Console.Beep();
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.DarkRed;
        System.Console.WriteLine("That's not a ticket number!!!");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.BackgroundColor = ConsoleColor.Black;
      }
      else
      {
        System.Console.WriteLine($"{Log[num - 1].Title} - {Log[num - 1].Description}");
        System.Console.WriteLine("Do you want to close this ticket? (Y/N)");
        string input = Console.ReadLine().ToLower();
        if (input == "y")
        {
          Log.Remove(Log[num - 1]);
          System.Console.WriteLine("Ticket Removed");
        }
      }

    }
  }
}