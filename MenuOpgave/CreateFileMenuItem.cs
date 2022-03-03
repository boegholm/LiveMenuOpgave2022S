using System;
using System.IO;

namespace MenuOpgave;

class CreateFileMenuItem : IMenuItem
{
    public CreateFileMenuItem(DirectoryInfo dir)
    {
        Title = "Create new File";
        Dir = dir;
    }
    public string Title { get; }
    public DirectoryInfo Dir { get; }

    public void Select()
    {
        Console.Clear();
        Console.WriteLine("Velkommen til opret-fil programmet!");
        Console.WriteLine();
        Console.Write("Hvad skal din file hedde?: ");
        string newFileName = Console.ReadLine();
        Console.Write("Hvad skal der stå i filen?:");
        string content = Console.ReadLine();
        File.WriteAllText(Path.Combine(Dir.FullName, newFileName), content);
        Console.WriteLine("Tillykke! vi har nu lavet en fil der hedder: "+ newFileName);
        Console.ReadKey();
    }
}
