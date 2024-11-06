public class Controller
{
  Meetings cMeetings;
  View cView;

  public Controller(Meetings meetings, View view)
  {
    cMeetings = meetings;
    cView = view;
  }

  // Methods to update each element in the list.
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

  public void UpdateDateTime()
  {
    int year, month, day, hour, minutes, seconds = 0;
    Console.WriteLine("Write the day as a number");
    Int32.TryParse(Console.ReadLine(), out day);
    Console.WriteLine("Write the month as a number");
    Int32.TryParse(Console.ReadLine(), out month);
    Console.WriteLine("Write the year as a number");
    Int32.TryParse(Console.ReadLine(), out year);
    Console.WriteLine("Write the hour as a number");
    Int32.TryParse(Console.ReadLine(), out hour);
    Console.WriteLine("Write the minutes as a number");
    Int32.TryParse(Console.ReadLine(), out minutes);
    DateTime newDateTime = new DateTime(year, month, day, hour, minutes, seconds);
    cMeetings.DateTime = newDateTime;
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
      cMeetings.Participants?.Add(newParticipant);
    }
    Console.WriteLine("Add more participants? (y/n)");
    string? inputParticipants = Console.ReadLine();
    switch (inputParticipants)
    {
      case "n":
        return;
      case "y":
        UpdateParticipants();
        return;
    }
  }

  // Methods to output the list contents.
  public void DisplayMeeting()
  {
    Console.WriteLine("-----------------");
    cView.Display(cMeetings);
  }

  public void Run()
  {
    Console.WriteLine("1. Add a new meeting");
    Console.WriteLine("2. Display meetings");
    Console.WriteLine("3. Exit");
    int inputRun = 0;
    try
    {
      inputRun = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
      Run();
    }
    switch (inputRun)
    {
      case 1:
        UpdateTitle();
        UpdateDateTime();
        UpdateOrganizer();
        UpdateParticipants();
        // cMeetings.Meeting();
        Run();
        return;
      case 2:
        DisplayMeeting();
        Console.WriteLine("--Press enter to continue--");
        Console.ReadLine();
        Run();
        return;
      case 3:
        break;
      default:
        Run();
        break;
    }
  }
}