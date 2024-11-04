public class Controller
{
  Meetings cMeetings;
  View cView;

  public Controller(Meetings meetings, View view)
  {
    cMeetings = meetings;
    cView = view;
  }

  public void UpdateTitle()
  {
    Console.WriteLine("Write the title of the meeting");
    string? newTitle = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(newTitle))
    {
      Console.WriteLine("Title cannot be empty");
    }
    else
    {
      cMeetings.Title = newTitle;
    }
  }
  public void UpdateDate()
  {
    Console.WriteLine("Input meeting date and time (format DD,MM,YYYY,HH,MM)");
    while (!DateTime.TryParse(Console.ReadLine(), out DateTime newDate))
    {
      Console.WriteLine("Incorrect format. Use DD,MM,YYYY,HH,MM.");
      DateTime.TryParse(Console.ReadLine(), out newDate);
      cMeetings.Date = newDate;
    }
  }
  public void UpdateOrganizer()
  {
    Console.WriteLine("Write who is in charge of the meeting?");
    string? newOrganizer = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(newOrganizer))
    {
      Console.WriteLine("Input cannot be empty");
    }
    else
    {
      cMeetings.Organizer = newOrganizer;
    }
  }
  public void UpdateParticipants()
  {
    Console.WriteLine("Write who is attending the meeting?");
    string? newParticipants = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(newParticipants))
    {
      Console.WriteLine("Input cannot be empty");
    }
    else
    {
      cMeetings.Participants.Add(newParticipants);
    }
  }
  public void DisplayMeeting()
  {
    cView.Display(cMeetings);
  }
}