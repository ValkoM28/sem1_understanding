//ex2
public class TaskDisplay
{
    public void DisplayTask(string taskName, string department,  string deadline, bool isComplete)
    {
        string status = isComplete ? "[COMPLETE]" : "[IN PROGRESS]";
        string display=$"""

            TASK={taskName}
            DEPARTMENT={department}
            DEADLINE={deadline}
            STATUS:{isComplete}

            """;
            Console.WriteLine(display);
    }
    
}   

class Program
{
    public static void Main(string[] args)
    {
        var display = new TaskDisplay();
        display.DisplayTask("Update website", "IT",  "Friday", true);
        display.DisplayTask("Review report", "Finance", "Tomorrow",  false);
    }
}