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

  // public void AddMeeting(Meetings meetings)
  // {
  //   meetingsList.Add(meetings);
  // }
  // Forcing the format of the output to have this structure.

  public override string ToString()
  {
    string listParticipants = String.Join(", ", Participants);
    return $"Title: {Title}\nOrganizer: {Organizer}\nDateTime: {DateTime}\nParticipants: {listParticipants}";
  }
}