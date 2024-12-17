public class ChecklistGoal : Goal
{
    private int TargetCount { get; set; }
    private int CurrentCount { get; set; }
    private int Bonus { get; set; }

    public ChecklistGoal(string name, int value, int targetCount, int bonus) : base(name, value)
    {
        TargetCount = targetCount;
        CurrentCount = 0;
        Bonus = bonus;
    }

    public override void RecordEvent()
    {
        CurrentCount++;
        if (CurrentCount >= TargetCount)
        {
            IsComplete = true;
            Console.WriteLine($"Completed checklist goal: {Name} and earned {Value + Bonus} points!");
        }
        else
        {
            Console.WriteLine($"Recorded event for goal: {Name} and earned {Value} points! Progress: {CurrentCount}/{TargetCount}");
        }
    }

    public override string GetStatus() => IsComplete ? "[X] Completed" : $"[ ] Completed {CurrentCount}/{TargetCount}";
    public override void Save() { /* Implement saving logic */ }
    public override void Load() { /* Implement loading logic */ }
}
