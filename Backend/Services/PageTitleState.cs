namespace Backend.Services;

public class PageTitleState
{
    public string Title { get; private set; } = "Home";

    public event Action? OnChange;
    
    public void SetTitle(string title)
    {
        if (Title == title)
            return;
        
        Title = title;
        OnChange?.Invoke();
    }
}