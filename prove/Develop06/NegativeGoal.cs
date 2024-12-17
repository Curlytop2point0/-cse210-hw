public class NegativeGoal : Goal
{
    public NegativeGoal(string name, int value) : base(name, value) { }

    public override void RecordEvent() => Console.WriteLine($"Recorded negative event for goal: {Name} and lost {Value} points!");
    public override string GetStatus() => IsComplete ? "[X] Recorded" : "[ ] Not recorded";
    public override void Save() { /* Implement saving logic */ }
    public override void Load() { /* Implement loading logic */ }
}
