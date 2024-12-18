public class Running : Activity
{
    private double Distance { get; }

    public Running(string date, int minutes, double distance) : base(date, minutes) => Distance = distance;
    public override double GetDistance() => Distance;
    public override double GetSpeed() => (Distance / Minutes) * 60;
    public override double GetPace() => Minutes / Distance;
}
