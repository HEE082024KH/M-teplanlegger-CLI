public class Meetings
{
  public string? Title { get; set; }
  public string? Organizer { get; set; }
  public DateOnly Date { get; set; }
  public TimeOnly Time { get; set; }
  public List<string>? Participants { get; set; }
  public List<string>? meetingList { get; set; }

  public void Meeting(string title, string organizer, DateOnly date, TimeOnly time, List<string> participants)
  {
    Title = title;
    Organizer = organizer;
    Date = date;
    Time = time;
    Participants = participants;
  }

  public List<Meetings>? MeetingsList(List<Meetings> meetings)
  {
    if (meetingList != null && Participants != null)
    {
      meetingList.AddRange(Participants);
    }
    else
    {
      Console.WriteLine("Lists cannot be empty");
    }
    return meetings;
  }

  public override string ToString()
  {
    return $"Title: {Title}\nOrganizer: {Organizer}\nDate: {Date}\nTime: {Time}\nParticipants: {Participants.ForEach (string participants) => participants}";
  }
}