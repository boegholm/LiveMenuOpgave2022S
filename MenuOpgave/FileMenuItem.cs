using System;
using System.IO;

namespace MenuOpgave;


class FileMenuItem : IMenuItem
{
    public FileMenuItem(FileInfo file)
    {
        File = file;
    }
    public string Title
    {
        get
        {
            return "F: "+ File.Name;
        }
    }
    public FileInfo File { get; }

    public void Select()
    {
        Console.WriteLine(Title);
        Console.WriteLine("Filstørrelse: "+ File.Length);
        Console.ReadKey();
    }
}
