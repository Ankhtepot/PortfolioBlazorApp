namespace Portfolio.BlazorApp.Services;

public static class Extensions
{
    public static int GetRandom(this int maxValue)
    {
        return Random.Shared.Next(maxValue);
    }
}