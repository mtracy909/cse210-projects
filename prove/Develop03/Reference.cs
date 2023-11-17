public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _verse2;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _verse2 = 0;
    }
    public Reference(string book, int chapter, int verse, int verse2)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _verse2 = verse2;
    }

    public string getReference()
    {
        if (_verse2 == 0)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_verse2}";
        }
    }
}