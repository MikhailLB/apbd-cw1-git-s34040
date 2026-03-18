namespace ConsoleApp2.App;

public class EntryPoint
{
    public static void Main(string[] args)
    {
        int userExperience = 1250;
        string userName = "Alex";

        int level = CalculateLevel(userExperience);

        Console.WriteLine($"user: {userName}");
        Console.WriteLine($"exp: {userExperience} XP");
        Console.WriteLine($"current level: {level}");
    }

    public static int CalculateLevel(int xp)
    {
        if (xp < 0) return 0;
        
        return (int)(Math.Sqrt(xp) / 5);
    }
}