using System;
using System.Threading;

public abstract class Activity
{
    protected string Name { get; set; }
    protected string Description { get; set; }
    protected int Duration { get; set; }

    public void Start()
    {
        Console.WriteLine($"Starting {Name} activity...");
        Console.WriteLine(Description);
        Console.Write("Enter the duration in seconds: ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        Pause();

        Execute();

        Console.WriteLine("Well Done!");
        Console.WriteLine($"You have completed the {Name} activity for {Duration} seconds.");
        Pause();
    }

    protected abstract void Execute();

    protected void Pause()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
