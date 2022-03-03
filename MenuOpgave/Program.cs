using System;

namespace MenuOpgave;

class Program
{
    static void Main(string[] args)
    {
        Menu m = new Menu("Min menu");
        m.Add(new MenuItem("Punkt 1", "Dette er mit første menupunkt"));
        m.Add(new MenuItem("Punkt 2", "Her er et andet"));
        m.Add(new MenuItem("Punkt 3", "Menupunkt nummer tre!"));
        m.Start();
    }
}
