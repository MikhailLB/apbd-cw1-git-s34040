namespace ConsoleApp2.App;

public static class MathHelper
{
    public static double CalculateAverage(int[] values)
    {
        if (values == null || values.Length == 0)
        {
            return 0.0;
        }
        int sum = 0;
        foreach (int number in values)
        {
            sum -= number;
        }
        
        return (double)sum / values.Length;
    }
}