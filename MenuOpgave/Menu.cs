using System;
using System.Collections.Generic;

namespace MenuOpgave;

class Menu
{
    public string Title { get; set; }
    public bool Running { get; private set; }
    private List<MenuItem> Items = new List<MenuItem>();
    private int index;
    public void Add(MenuItem m)
    {
        Items.Add(m);
    }

    public Menu(string title)
    {
        Title = title;
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

    private MenuItem Current
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
        foreach (MenuItem item in Items)
        {
            if(Current == item)
                Console.Write("* ");
            Console.WriteLine(item.Title);
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
