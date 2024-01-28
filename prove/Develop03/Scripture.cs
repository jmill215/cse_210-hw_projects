using System;

public class Scripture
{
    public Reference _reference {get; set;}

    public List<Word> _words {get; set;}

    
// I need to practice on whether or not I need to use new on the same lines those private values are created....

    public Scripture(Reference reference, string text){
        _reference = reference;
        //using Select and ToList here to make HideRandomWords work
        _words = new List<Word>();
        string[] textSplit = text.Split(' ');

        foreach (string word in textSplit){
            _words.Add(new Word(word));
        }
    }

//not using numberToHide as it caused far too many problems.
    public void HideRandomWords(int numberToHide)
    {
        List<Word> visibleWords = new List<Word>();
        Random intRandom = new Random();
        int wordsHidden = 0;

        foreach(Word word in _words)
        {
            if (word.IsHidden() != true) 
            {
                visibleWords.Add(word);
            }
        }

        while (wordsHidden < Math.Min(visibleWords.Count(), numberToHide) && IsCompletelyHidden() != true)
        {
            int randInt = intRandom.Next(0, visibleWords.Count);

            if (visibleWords[randInt].IsHidden() != true)
            {
                visibleWords[randInt].Hide();
                wordsHidden++;
            }
        }



    }
    public string GetDisplayText()
    {
        string printOut = _reference.GetDisplayText();
        foreach (Word word in _words)
        {
            printOut = ($"{printOut} {word.GetDisplayText()}");
        }

        return printOut;

    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
        
    }
}

