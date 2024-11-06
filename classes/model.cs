public class Meetings
{
  // Define the elements for each meeting.
  public string? Title { get; set; }
  public string? Organizer { get; set; }
  public DateTime DateTime { get; set; }
  public List<string>? Participants { get; set; } = new List<string>();

  // Define the list of meetings.
  public List<string>? meetingsList { get; set; }

  public void Meeting(string title, string organizer, DateTime dateTime, List<string> participants)
  {
    Title = title;
    Organizer = organizer;
    DateTime = dateTime;
    Participants = participants;
  }

  // If list entry it not empty, add it to the Participants list.
  public List<Meetings>? MeetingList(List<Meetings> meetings)
  {
    if (meetingsList != null && Participants != null)
    {
      meetingsList.AddRange(Participants);
    }
    else
    {
      Console.WriteLine("Lists cannot be empty");
    }
    return meetings;
  }
  // Forcing the format of the output to have this structure.
  public override string ToString()
  {
    string listParticipants = String.Join(", ", Participants);
    return $"Title: {Title}\nOrganizer: {Organizer}\nDateTime: {DateTime}\nParticipants: {listParticipants}";
  }
}