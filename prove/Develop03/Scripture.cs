using System.Diagnostics.Metrics;

public class Scripture
{
    private int _counter = 0;
    private string _words;
    private List<Word> _wordsList = new List<Word>();
    private List<string> _stringList = new List<string>();
    public Scripture(string words)
    {
        _words = words;
        foreach (string word in _words.Split(" "))
        {
            Word _newWord = new Word(word);
            _wordsList.Add(_newWord);
        }
    }
    public string GetScripture()
    {
        return _words;
    }
    public int GetCounter()
    {
        return _counter;
    }
    public List<Word> GetWordsList()
    {
        return _wordsList;
    }

    public void SetStringList(List<string> strings)
    {
        _stringList = strings;
    }

    public void HideWords()
    {
        {
            Random random = new Random();
            int num = random.Next(0, _wordsList.Count);
            while (_wordsList[num].GetIsShown() == false)
            {
                num = random.Next(0, _wordsList.Count);
            }
            _wordsList[num].Hide();
            foreach (Word word in _wordsList)
            {
                _stringList.Add(word.GetWord());
            }
            _words = String.Join(" ", _stringList);
            _counter++;
        }
    }
}