class Book : Item
{
    public string Author { get; }

    public Book(string id, string title, string author) : base(id, title)
    {
        Author = author;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Author: {Author}");
    }
}