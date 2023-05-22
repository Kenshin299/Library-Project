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
        if (book.IsBorrowed)
        {
            Console.WriteLine($"{book.Title} ya se prestó.");
        }
        else
        {
            book.IsBorrowed = true;
            Console.WriteLine($"{member.Name} tomó prestado {book.Title}.");
        }
    }
    public void ReturnBook(Book book)
    {
        book.IsBorrowed = false;
        Console.WriteLine($"{book.Title} fue devuelto.");
    }
    public void DisplayBorrowedBooks()
    {
        foreach (Book book in books)
        {
            if (book.IsBorrowed)
            {
                Console.WriteLine($"Titulo: {book.Title}, Autor: {book.Author}");
            }
        }
    }
}
