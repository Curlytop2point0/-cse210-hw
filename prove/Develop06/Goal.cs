public abstract class Goal
{
    public string Name { get; private set; }
    public int Value { get; private set; }
    protected bool IsComplete { get; set; }

    public Goal(string name, int value)
    {
        Name = name;
        Value = value;
        IsComplete = false;
    }

    public abstract void RecordEvent();
    public abstract string GetStatus();
    public abstract void Save();
    public abstract void Load();
}
