//ex3
public class MessageValidator
{
    public bool ValidateMessage(string message,  string levelInput, out int userLevel)
    {
        userLevel = 0;
        
        if(string.IsNullOrEmpty(message) || message.Length>200)
        {
            return false;
        }

        if(int.TryParse(levelInput, out userLevel))
        {
            return false;
        }

        if(userLevel<1 || userLevel>10)
        {
            return false;
        }

        return true;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        var validator = new   MessageValidator();
        if(validator.ValidateMessage("Hello everyone!", "5", out int level1))
        {
            Console.WriteLine($"Message accepted at level {level1}");
        }
        if(!validator.ValidateMessage("Hi there", "15", out int level2))
        {
            Console.WriteLine("Validation failed: Invalid user level");
        }
        if(!validator.ValidateMessage("Hi there", "abc",  out int level))
        {
            Console.WriteLine("Validation failed: Level must be a number");
        }
    }
}