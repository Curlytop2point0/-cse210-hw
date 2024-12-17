public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int value) : base(name, value) { }

    public override void RecordEvent()
    {
        IsComplete = true;
        Console.WriteLine($"Completed goal: {Name} and earned {Value} points!");
    }

    public override string GetStatus() => IsComplete ? "[X]" : "[ ]";
    public override void Save() { /* Implement saving logic */ }
    public override void Load() { /* Implement loading logic */ }
}
