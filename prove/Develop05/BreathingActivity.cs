public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        Name = "Breathing";
        Description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    protected override void Execute()
    {
        int iterations = Duration / 10;
        for (int i = 0; i < iterations; i++)
        {
            Console.WriteLine("Breathe in...");
            Pause();
            Console.WriteLine("Breathe out...");
            Pause();
        }
    }
}
