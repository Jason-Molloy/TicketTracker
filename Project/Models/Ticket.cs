namespace ticketTracker.Project.Models
{
  public class Ticket
  {
    public string Title { get; set; }
    public string Description { get; set; }

    public Ticket(string title, string description)
    {
      Title = title;
      Description = description;
    }
  }
}