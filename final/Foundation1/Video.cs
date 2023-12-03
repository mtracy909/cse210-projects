public class Video
{
    private string _title;
    private string _author;
    private float _length;
    private List<Comment> _comments = new List<Comment>();
    public Video(string title, string author, float length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public int GetNumComments()
    {
        return _comments.Count();
    }
    public float GetLength()
    {
        return _length;
    }
    public string GetTitle()
    {
        return _title;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public List<Comment> GetComments()
    {
        return _comments;
    }
}