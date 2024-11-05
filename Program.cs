namespace Møteplanlegger_CLI;

class Program
{
    static void Main(string[] args)
    {
        Meetings meetings = new();
        View view = new();
        Controller controller = new(meetings, view);

        // controller.DisplayMeeting();
        // controller.UpdateTitle();
        // controller.UpdateDate();
        // controller.UpdateTime();
        controller.UpdateDateTime();
        // controller.UpdateOrganizer();
        // controller.UpdateParticipants();
        controller.DisplayMeeting();
    }
}
