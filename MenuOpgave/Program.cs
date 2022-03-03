using System;

namespace MenuOpgave;

class Program
{
    static void Main(string[] args)
    {
        Menu sub = new Menu("SubMenu");
        sub.Add(new MenuItem("sub1", "content"));
        sub.Add(new MenuItem("sub2", "content"));
        sub.Add(new MenuItem("sub3", "content"));
        sub.Add(new MenuItem("sub4", "content"));
        Menu m = new Menu("Min menu");
        m.Add(new MenuItem("Punkt 1", "Dette er mit første menupunkt"));
        m.Add(new MenuItem("Punkt 2", "Her er et andet"));
        m.Add(new MenuItem("Punkt 3", "Menupunkt nummer tre!"));
        m.Add(new FileSystemMenu("../../../../"));
        m.Add(sub);
        m.Start();
    }
}
