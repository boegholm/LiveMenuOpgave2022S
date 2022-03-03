using System;
using System.Collections.Generic;

namespace MenuOpgave;







class Menu : AbstractMenuItem, IMenuItem
{
    public bool Running { get; private set; }
    private List<IMenuItem> Items = new List<IMenuItem>();
    private int index;
    public void Clear()
    {
        Items.Clear();
    }
    public void Add(IMenuItem m)
    {
        Items.Add(m);
    }

    public Menu(string title) : base(title)
    {
    }
    public override void Select()
    {
        Start();
    }
    public void Start()
    {
        Running = true;
        while (Running)
        {
            Draw();
            HandleInput();
        }
    }

    private IMenuItem Current
    {
        get
        {
            return Items[index];
        }
    }

    private void Draw()
    {
        Console.Clear();
        Console.WriteLine($"[{Title}]");
        foreach (IMenuItem item in Items)
        {

            if (Current == item)
            {
                var oldcolor = Console.BackgroundColor;
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.Write("* ");
                Console.WriteLine(item.Title);
                Console.BackgroundColor = oldcolor;
            }
            else
            {
                Console.WriteLine(item.Title);
            }
        }
    }
    private void HandleInput()
    {
        ConsoleKeyInfo ch = Console.ReadKey(true);
        switch (ch.Key)
        {
            case ConsoleKey.Escape:
            case ConsoleKey.Backspace:
                Running = false;
                break;
            case ConsoleKey.DownArrow:
                index = (index + 1) % Items.Count;
                break;
            case ConsoleKey.UpArrow:
                index = ((index + Items.Count) - 1) % Items.Count;
                break;
            case ConsoleKey.Enter:
                Current.Select();
                break;
            
        }
    }

}
