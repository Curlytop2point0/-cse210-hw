public class Cycling : Activity
{
    private double Speed { get; }

    public Cycling(string date, int minutes, double speed) : base(date, minutes) => Speed = speed;
    public override double GetDistance() => (Speed * Minutes) / 60;
    public override double GetSpeed() => Speed;
    public override double GetPace() => 60 / Speed;
}
