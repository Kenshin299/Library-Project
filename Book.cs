class Book
{
    public string Id { get; }
    public string Title { get; }
    public string Author { get; }
    public bool IsBorrowed { get; set; }
    public Book(string id, string title, string author)
    {
        Id = id;
        Title = title;
        Author = author;
        IsBorrowed = false;
    }
}