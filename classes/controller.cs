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
    int day, month, year;
    Console.WriteLine("Write the day as a number");
    Int32.TryParse(Console.ReadLine(), out day);
    Console.WriteLine("Write the month as a number");
    Int32.TryParse(Console.ReadLine(), out month);
    Console.WriteLine("Write the year as a number");
    Int32.TryParse(Console.ReadLine(), out year);

    DateOnly newDate = new DateOnly(year, month, day);
    cMeetings.Date = newDate;
  }

  public void UpdateTime()
  {
    Console.WriteLine("--------------------------------------");
    int hour, minutes, seconds = 0;
    Console.WriteLine("Write the hour as a number");
    Int32.TryParse(Console.ReadLine(), out hour);
    Console.WriteLine("Write the minutes as a number");
    Int32.TryParse(Console.ReadLine(), out minutes);

    TimeOnly newTime = new TimeOnly(hour, minutes, seconds);
    cMeetings.Time = newTime;
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
    Console.WriteLine("-----------------");
    cView.Display(cMeetings);
  }
}