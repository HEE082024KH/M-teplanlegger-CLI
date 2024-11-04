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
    Console.WriteLine("------------------------------");
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
    Console.WriteLine("--------------------------------------");
    Console.WriteLine("Input meeting date (format DD,MM,YYYY)");
    while (!DateOnly.TryParse(Console.ReadLine(), out DateOnly newDate))
    {
      Console.WriteLine("Incorrect format. Use DD,MM,YYYY format");
      DateOnly.TryParse(Console.ReadLine(), out newDate);
      cMeetings.Date = newDate;
    }
  }

  public void UpdateTime()
  {
    Console.WriteLine("---------------------------------");
    Console.WriteLine("Input meeting time (format HH:MM)");
    while (!TimeOnly.TryParse(Console.ReadLine(), out TimeOnly newTime))
    {
      Console.WriteLine("Incorrect format. Use HH:MM format");
      TimeOnly.TryParse(Console.ReadLine(), out newTime);
      cMeetings.Time = newTime;
    }
  }

  public void UpdateOrganizer()
  {
    Console.WriteLine("--------------------------------------");
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
    Console.WriteLine("-----------------------------------");
    Console.WriteLine("Write who is attending the meeting?");
    string? newParticipant = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(newParticipant))
    {
      Console.WriteLine("Input cannot be empty");
    }
    else
    {
      cMeetings.Participants.Add(newParticipant);
    }
  }
  public void DisplayMeeting()
  {
    cView.Display(cMeetings);
  }
}