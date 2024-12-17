public class ProgressGoal : Goal
{
    private int Target { get; set; }
    private int CurrentProgress { get; set; }

    public ProgressGoal(string name, int value, int target) : base(name, value)
    {
        Target = target;
        CurrentProgress = 0;
    }

    public override void RecordEvent()
    {
        Console.Write("Enter the amount of progress made: ");
        CurrentProgress += int.Parse(Console.ReadLine());

        if (CurrentProgress >= Target)
        {
            IsComplete = true;
            Console.WriteLine($"Completed goal: {Name} and earned {Value} points!");
        }
        else
        {
            Console.WriteLine($"Recorded progress for goal: {Name}. Current progress: {CurrentProgress}/{Target}");
        }
    }

    public override string GetStatus() => IsComplete ? "[X] Completed" : $"[ ] Progress: {CurrentProgress}/{Target}";
    public override void Save() { /* Implement saving logic */ }
    public override void Load() { /* Implement loading logic */ }
}
