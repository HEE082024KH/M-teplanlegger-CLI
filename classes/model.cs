public class Meetings
{
  public string? Title { get; set; }
  public string? Organizer { get; set; }
  public DateTime Date { get; set; }
  public List<string>? Participants { get; set; }
  public List<string>? meetingList { get; set; }

  public void Meeting(string title, string organizer, DateTime date, List<string> participants)
  {
    Title = title;
    Organizer = organizer;
    Date = date;
    Participants = participants;
  }

  public List<Meetings>? MeetingsList(List<string> meetings)
  {
    if (meetingList != null && Participants != null)
    {
      meetingList.AddRange(Participants);
    }
    else
    {
      Console.WriteLine("Lists cannot be empty");
    }
  }

  public override string ToString()
  {
    return $"Title: {Title}\nOrganizer: {Organizer}\nDate: {Date}\nParticipants: {Participants}";
  }
}