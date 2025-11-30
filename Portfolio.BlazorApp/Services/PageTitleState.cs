namespace Portfolio.BlazorApp.Services;

public class PageTitleState
{
    public string Title { get; private set; } = "Home";

    public event Action? OnChange;
    
    public static PageTitleState Instance { get; } = new PageTitleState();

    public void SetTitle(string title)
    {
        Title = title;
        OnChange?.Invoke();
    }
}