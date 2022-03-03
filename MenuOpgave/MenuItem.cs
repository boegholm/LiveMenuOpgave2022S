namespace MenuOpgave;
using System;
class MenuItem
{
    public MenuItem(string title, string content)
    {
        Title = title;
        Content = content;
    }
    public string Title { get; set; }
    private string Content { get; set; }
    public void Select()
    {
        Console.Clear();
        Console.WriteLine(Title);
        Console.WriteLine(Content);
        Console.ReadKey();
    }
}
