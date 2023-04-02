using System;

public class SymptomManager
{
    private List<SymptomTriggerSet> _symptomTriggerSets;

    public SymptomManager()
    {
        _symptomTriggerSets = new List<SymptomTriggerSet>();
    }

    
    public void AddSymptomTriggerSet(SymptomTriggerSet set)
    {
        _symptomTriggerSets.Add(set);
    }

    public List<SymptomTriggerSet> GetSymptomTriggerList()
    {
        return _symptomTriggerSets;
    } 


    public void SavesymptomTriggerList(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (SymptomTriggerSet symptomItem in _symptomTriggerSets)  //loops through Sets
            {
                Symptom symptom = symptomItem.GetSymptom(); 
                string serializedSymptom = symptom.Serialize();
                outputFile.Write($"{serializedSymptom}");

                List<Trigger> triggers = symptomItem.GetTriggers();
                foreach (Trigger triggerItem in triggers)
                {
                    Trigger trigger = triggerItem;
                    string serializedTrigger = triggerItem.Serialize();
                    outputFile.Write($"~{serializedTrigger}");
                }
                outputFile.WriteLine();
            }
        }
    }

    public void LoadSymptomTriggerList(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            SymptomTriggerSet set = new SymptomTriggerSet();
            bool firstLoop = true;

            string[] parts = line.Split("~");
            foreach (string part in parts)
            {
                if (firstLoop == true)
                {
                    Symptom symptom = new Symptom();
                    string[] symptomParts = part.Split("|");
                    symptom.Deserialize(symptomParts);
                    set.SetSymptom(symptom);
                    firstLoop = false;
                }

                else
                {
                    Trigger trigger = new Trigger();
                    string[] triggerparts = part.Split("|");
                    trigger.Deserialize(triggerparts);
                    set.AddTriggerToList(trigger);
                }
            }

            AddSymptomTriggerSet(set);
        }
    }
}