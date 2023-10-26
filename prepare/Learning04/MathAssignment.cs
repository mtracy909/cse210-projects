public class MathAssignment : Assignment
{
    private string _textbookSection;

    private string _problems;

    public MathAssignment(string _studentName, string _topic, string textbookSection, string problems) : base(_studentName, _topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
    public string getHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}