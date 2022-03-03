namespace MenuOpgave;

abstract class AbstractMenuItem
{
    public string Title { get; set; }

    protected AbstractMenuItem(string title)
    {
        Title = title;
    }

    public abstract void Select();
}
