using System;

public class Word
{
    private List<string> _words = new List<string>();
    private string _word;
    private List<int> _numbers = new List<int>();
    private List<int> _numbersUsed = new List<int>();
    private int _number;
    private string _verse;
    
// populates _words and _numbers list when class is instantiated
    public Word(string verse)
    {
        _verse = verse;
        string[] words = _verse.Split(" ");
        foreach (string word in words)
        {
            _words.Add(word);
        }
        
        int number = _words.Count() - 1;
        for (int i = 0; i <= number; i++)
        {
            _numbers.Add(i);
        }    
    }

     public List<int> GetNumbers()
    {
        return _numbers;
    }

    public void DisplayWords()
    {   
        foreach (string word in _words)
        {
            int verseNum = 0;
            bool result = int.TryParse(word, out verseNum);

            if (result == true)
            {
                int wordIndex = _words.FindIndex(a => a.Contains(word));
                _numbers.Remove(wordIndex);
                Console.WriteLine();
            }

            Console.Write($" {word}");
            
        }
        
    }

    public void ReplaceWords()
    {
        foreach (int number in _numbersUsed)
            {
                _word = _words[number];
                _word = new string('_', _word.Length); 
                _words[number] = _word;
            }
    }

    public void ChooseWords()
        {
            if (_numbers.Count() >= 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    var randomGen = new Random();
                    int index = randomGen.Next(_numbers.Count);
                    _number = _numbers[index];
                    _numbers.RemoveAt(index);
                    _numbersUsed.Add(_number);
                }

            }

            else if (_numbers.Count() > 0)
            {
               for (int i = 0; i <= _numbers.Count(); i++)
                {
                    var randomGen = new Random();
                    int index = randomGen.Next(_numbers.Count);
                    _number = _numbers[index];
                    _numbers.RemoveAt(index);
                    _numbersUsed.Add(_number);
                }
            }
            
        }
    
    public void RestoreWords()
    {
        _words.Clear();
        string[] words = _verse.Split(" ");
        foreach (string word in words)
        {
            _words.Add(word);
        }
    }
}    