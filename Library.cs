class Library
{
    private List<Book> books;
    private List<Member> members;
    public Library()
    {
        books = new List<Book>();
        members = new List<Member>();
    }
    public void AddBook(Book book)
    {
        books.Add(book);
    }
    public void AddMember(Member member)
    {
        members.Add(member);
    }
    public void BorrowBook(Book book, Member member)
    {
        if (!book.IsAvailable)
        {
            Console.WriteLine($"{book.ItemName} ya se prestó.");
        }
        else
        {
            book.IsAvailable = false;
            Console.WriteLine($"{member.Name} tomó prestado {book.ItemName}.");
    }

    }
    public void ReturnBook(Book book)
    {
        book.IsAvailable = true;
        Console.WriteLine($"{book.ItemName} fue devuelto.");
    }
    public void DisplayBorrowedBooks()
    {
        foreach (Book book in books)
        {
        if (!book.IsAvailable)
            {
                Console.WriteLine($"Titulo: {book.ItemName}, Autor: {book.Author}");
            }
        }
    }   
}
