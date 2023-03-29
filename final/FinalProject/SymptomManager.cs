using System;

public class SymptomManager
{
    private List<SymptomTriggerSet> _symptomTriggerSets;

    
    public void AddSymptomTriggerSet(SymptomTriggerSet set)
    {
        _symptomTriggerSets.Add(set);
    }

    public void ModifySymptom()
    {

    }

    public List<SymptomTriggerSet> GetSymptomTriggerSet()
    {
        return _symptomTriggerSets;
    } 


    public void SaveCombined()
    {

    }

    public void LoadCombined()
    {

    }

    public void ListBySymptom()
    {

    }

    public void ListByTrigger()
    {

    }

    public void ListByDate()
    {

    }




}