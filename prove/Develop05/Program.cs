class Program
{
    static void Main(string[] args)
    {
        ActivityTracker activityTracker = new ActivityTracker();

        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Display Activity Log");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());

            Activity activity = null;

            switch (choice)
            {
                case 1:
                    activity = new BreathingActivity();
                    break;
                case 2:
                    activity = new ReflectionActivity();
                    break;
                case 3:
                    activity = new ListingActivity();
                    break;
                case 4:
                    activityTracker.DisplayLog();
                    continue;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
            }

            activity.Start();
            activityTracker.LogActivity(activity.GetType().Name);
        }
    }
}
