using System.IO;

namespace MenuOpgave;

class FileSystemMenu : Menu
{
    DirectoryInfo Dir;
    public FileSystemMenu(string path) : this(new DirectoryInfo(path))
    {
    }
    public FileSystemMenu(DirectoryInfo dir) : base(dir.Name)
    {
        this.Dir = dir;
    }

    public override void Select()
    {
        Clear();
        Add(new CreateFileMenuItem(Dir));
        foreach(DirectoryInfo v in Dir.GetDirectories())
        {
            Add(new FileSystemMenu(v));
        }
        foreach(FileInfo v in Dir.GetFiles())
        {
            Add(new FileMenuItem(v));
        }
        base.Select();
    }
}
