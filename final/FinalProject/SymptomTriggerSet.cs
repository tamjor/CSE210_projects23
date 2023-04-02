using System;

public class SymptomTriggerSet
{
    private Symptom _symptom;
    private List<Trigger> _triggers;

    public SymptomTriggerSet()
    {
        _triggers = new List<Trigger>();
    }

    public void AddTriggerToList(Trigger trigger)
    {
        _triggers.Add(trigger);
    }

    public void SetSymptom(Symptom symptom)
    {
        _symptom = symptom;
    }

    public Symptom GetSymptom()
    {
        return _symptom;
    }

    public List<Trigger> GetTriggers()
    {
        return _triggers;
    }

    public void DisplaySet()
    {
        _symptom.DisplaySymptom();
        foreach (Trigger trigger in _triggers)
        {
            trigger.DisplayTrigger();
        }
    }

}