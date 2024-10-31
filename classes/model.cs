public class Meetings
{
  public string? Title { get; set; }
  public DateTime Date { get; set; }
  public string? Organizer { get; set; }
  public string? Participants { get; set; }

  public void Meeting(string title, DateTime date, string organizer, string participants)
  {
    Title = title;
    Date = date;
    Organizer = organizer;
    Participants = participants;
  }

  public override string ToString()
  {
    return $"Title: {Title}\nDate: {Date}\nOrganizer: {Organizer}\nParticipants: {Participants}";
  }

  public class Model()
  {
  }
}