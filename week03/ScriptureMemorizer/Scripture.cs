using System;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] words = text.Split(" ");

        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    
    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText();

        foreach ( Word word in _words)
            {
                displayText += " " + word.GetDisplayText();
            }
        return displayText;
    }
    public void HideRandomWords(int numberToHide)
    {
    Random random = new Random();

    for (int i = 0; i < numberToHide; i++)
    {
        List<Word>visibleWords = new List<Word>();

        foreach (Word word in  _words)
            {
                if (!word.IsHidden())
                {
                    visibleWords.Add(word);
                }
                
            }

           
            if (visibleWords.Count== 0)
                {
                    break;
                }
            
             int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
    }
    
    }

    public bool IsCompletelyHidden()
    {
        foreach(Word word in _words)
        {
            if(!word.IsHidden())
            {
                return false;
            }
        } 
        return true;
    }
}