public class Swimming : Activity
{
    private int Laps { get; }

    public Swimming(string date, int minutes, int laps) : base(date, minutes) => Laps = laps;
    public override double GetDistance() => (Laps * 50) / 1000.0;
    public override double GetSpeed() => (GetDistance() / Minutes) * 60;
    public override double GetPace() => Minutes / GetDistance();
}

