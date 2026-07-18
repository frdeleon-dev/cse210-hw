public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] allWords = text.Split(' ');
        foreach (string wordText in allWords)
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        List<Word> visibleWords = new List<Word>();

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        int actualToHide = Math.Min(numberToHide, visibleWords.Count);

  
        for (int i = 0; i < actualToHide; i++)
        {
            int randomIndex = random.Next(0, visibleWords.Count);
            Word wordToHide = visibleWords[randomIndex];
            wordToHide.Hide();

            visibleWords.RemoveAt(randomIndex);
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + " ";

        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }

        return displayText.Trim(); 
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false; 
            }
        }
        return true;
    }
}
