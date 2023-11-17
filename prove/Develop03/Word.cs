using System.Runtime.CompilerServices;

public class Word
{
    private string _word;
    private bool _isShown;

    public Word(string word)
    {
        _word = word;
        _isShown = true;
    }
    public Word(string word, bool isShown)
    {
        _word = word;
        _isShown = isShown;
    }

    public void Hide()
    {
        _isShown = false;
        _word = string.Concat(Enumerable.Repeat("_", _word.Length));
    }

    public bool GetIsShown()
    {
        return _isShown;
    }

    public string GetWord()
    {
        return _word;
    }
}