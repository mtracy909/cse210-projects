public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string title, string _studentName, string _topic) : base(_studentName, _topic)
    {
        _title = title;
    }
    public string getWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }
}