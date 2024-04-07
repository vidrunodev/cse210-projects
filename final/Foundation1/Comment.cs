public class Comment
{
    public string UserName { get; private set; }
    public string Text { get; private set; }

    public Comment(string userName, string text)
    {
        UserName = userName;
        Text = text;
    }
}
