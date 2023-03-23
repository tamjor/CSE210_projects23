using System;

public class MuscularSystem : BodySystem
{


    public MuscularSystem()
    {
        _systemType = "Muscular";
    }

    public void SetSeverity(string severity)
    {
        _systemSeverity = severity;
    }
    public override void AddSystem()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
    
    public override void MakeChange()
    {
        
    }
}