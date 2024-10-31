public class Controller
{
  Meetings cMeetings;

  public Controller(Meetings meetings)
  {
    cMeetings = meetings;
  }

  public void UpdateTitle()
  {
    Console.WriteLine("Write the title of the meeting");
    string? newTitle = Console.ReadLine();
    while (newTitle == null)
    {
      if (string.IsNullOrWhiteSpace(newTitle))
      {
        Console.WriteLine("Title cannot be empty");
      }
      else
      {
        cMeetings.Title = newTitle;
      }
    }
  }
  public void UpdateDate()
  {
    Console.WriteLine("Input meeting date and time(format DD,MM,YYYY,HH,MM)");
    if (DateTime.TryParse(Console.ReadLine(), out DateTime newDate))
    {
      DateTime date = newDate;
    }
    else
    {
      Console.WriteLine("Incorrect format. Use DD,MM,YYYY,HH,MM.");
    }
  }
}