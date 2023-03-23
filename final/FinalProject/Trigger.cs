 using System;

 public abstract class Trigger
 {
    protected string _triggerType;
    protected string _triggerDescription;
    protected string _triggerTiming;


    public abstract void AddTrigger();

    public abstract void MakeChange();
    



 }