using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        Name = "Listing";
        Description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    protected override void Execute()
    {
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine(prompt);
        Pause();

        List<string> items = new List<string>();
        int endTime = Environment.TickCount + Duration * 1000;
        while (Environment.TickCount < endTime)
        {
            Console.Write("List an item: ");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"You listed {items.Count} items.");
    }
}
