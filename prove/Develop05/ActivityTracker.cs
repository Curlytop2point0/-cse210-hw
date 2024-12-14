using System;
using System.Collections.Generic;

public class ActivityTracker
{
    private Dictionary<string, int> activityCounts = new Dictionary<string, int>();

    public void LogActivity(string activityName)
    {
        if (activityCounts.ContainsKey(activityName))
        {
            activityCounts[activityName]++;
        }
        else
        {
            activityCounts[activityName] = 1;
        }
    }

    public void DisplayLog()
    {
        Console.WriteLine("Activity Log:");
        foreach (var entry in activityCounts)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value} times");
        }
    }
}
