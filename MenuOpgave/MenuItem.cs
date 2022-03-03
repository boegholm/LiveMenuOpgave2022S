namespace MenuOpgave;
using System;
class MenuItem : AbstractMenuItem, IMenuItem
{
    public MenuItem(string title, string content) : base(title)
    {
        Content = content;
    }
    private string Content { get; set; }
    public override void Select()
    {
        Console.Clear();
        Console.WriteLine(Title);
        Console.WriteLine(Content);
        Console.ReadKey();
    }
}
