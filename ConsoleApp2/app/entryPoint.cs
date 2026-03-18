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
        if (xp <= 0) return 0;
        
        return (int)(Math.Sqrt(xp) / 5);
    }
    public static int CalculateMax(int[] values)
    {

        if (values == null || values.Length == 0)
        {
            throw new ArgumentException("array can't be empty or null.");
        }

        int max = values[0];

        for (int i = 1; i < values.Length; i++)
        {
            if (values[i] > max)
            {
                max = values[i];
            }
        }

        return max;
    }
    public static int CalculateMin(int[] values)
    {
        if (values == null || values.Length == 0)
        {
            throw new ArgumentException("Array can't be empty");
        }

        int min = values[0];

        for (int i = 1; i < values.Length; i++)
        {
            if (values[i] < min)
            {
                min = values[i];
            }
        }

        return min;
    }
}