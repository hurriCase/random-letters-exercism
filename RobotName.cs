using System;
using System.Collections.Generic;
public class Robot
{
    private  static readonly HashSet<string> RobotsList = [];
    
    private static readonly Random Rnd = new();
    public string Name
    { get; private set; }

    public Robot() =>
        AddRobotName();
    private void AddRobotName()
    {
        do
        {
            Name = string.Format("{0}{1}{2}{3}{4}",
                (char)Rnd.Next('A', 'Z' + 1),
                (char)Rnd.Next('A', 'Z' + 1),
                    Rnd.Next(0, 10),   
                    Rnd.Next(0, 10),
                    Rnd.Next(0, 10));
        }
        while (!RobotsList.Add(Name));
    }
    public void Reset() => AddRobotName();
}