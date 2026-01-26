// Scripture.cs
class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        
        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        
        // Get list of words that are not hidden
        List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();
        
        // Hide the specified number of words or all remaining visible words
        int wordsToHide = Math.Min(numberToHide, visibleWords.Count);
        
        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        string scriptureText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{referenceText} {scriptureText}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }

    public int GetPercentageHidden()
    {
        int totalWords = _words.Count;
        int hiddenWords = _words.Count(w => w.IsHidden());
        return (int)((double)hiddenWords / totalWords * 100);
    }
}