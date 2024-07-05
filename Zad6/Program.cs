using System;
using System.Collections.Generic;

public abstract class Device
{
    public string Name { get; set; }

    public Device(string name)
    {
        Name = name;
    }

    public abstract void DisplayInfo();
}
public class Computer : Device
{
    public Computer(string name) : base(name)
    {
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Computer Name: {Name}");
    }
}
public class Router : Device
{
    public Router(string name) : base(name)
    {
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Router Name: {Name}");
    }
}

public class Printer : Device
{
    public Printer(string name) : base(name)
    {
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Printer Name: {Name}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        List<Device> devices = new List<Device>
        {
            new Computer("MSI Gaming Pro X"),
            new Printer("HP LaserJet Pro"),
            new Router("UPC PlayBox")
        };

        foreach (var device in devices)
        {
            device.DisplayInfo();
        }
    }
}
