public class EternalGoal : Goal
{
    public EternalGoal(string name, int value) : base(name, value) { }

    public override void RecordEvent() => Console.WriteLine($"Recorded event for goal: {Name} and earned {Value} points!");
    public override string GetStatus() => "[ ]";
    public override void Save() { /* Implement saving logic */ }
    public override void Load() { /* Implement loading logic */ }
}
