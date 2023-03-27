 using System;

 public class Trigger
 {
    protected string _triggerType;
    private string _triggerIntensity;
    protected string _triggerDescription;
    protected string _triggerTiming;


    public void LogTrigger()
    {
        Console.Write("What type of trigger would you like to add? ");
        _triggerType = Console.ReadLine();
        Console.Write("How would you rank the intensity of this trigger on a scale of 1 to 10? ");
      _triggerIntensity = Console.ReadLine();
            Console.Write("Give a brief description of the trigger: ");
      _triggerDescription = Console.ReadLine();
            Console.Write("When did the trigger occur(MM/DD/HH/MM)? ");
      _triggerTiming = Console.ReadLine();
   }

    
 }