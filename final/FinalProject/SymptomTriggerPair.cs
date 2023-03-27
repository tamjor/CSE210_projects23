using System;

public class SymptomTriggerPair
{
    private Symptom _symptom;
    private List<Trigger> _triggers;

public void AddTriggerToList(Trigger trigger)
{
    _triggers.Add(trigger);
}
public void SetSymptom(Symptom symptom)
{
    _symptom = symptom;
}


}