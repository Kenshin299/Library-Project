class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();

        // Agregando libros a la libreria
        Book book1 = new Book("001", "The Great Gatsby", "F. Scott Fitzgerald");
        Book book2 = new Book("002", "Mistborn", "Brando Sanderson");
        Book book3 = new Book("003", "Don Quijote de la Mancha", "Miguel de Cervantes");
        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);

        // Agregando los miembros a la libreria
        Member member1 = new Member("Pedro Sanchez", "M001");
        Member member2 = new Member("Rudy Eugenio", "M002");
        library.AddMember(member1);
        library.AddMember(member2);

        // Pidiendo libros prestados
        library.BorrowBook(book1, member1);
        library.BorrowBook(book2, member1);
        library.BorrowBook(book3, member2);

        // Mostrando libros prestados
        Console.WriteLine("Libros prestados actualmente:");
        library.DisplayBorrowedBooks();

        // Devolviendo los libros
        library.ReturnBook(book1);
        library.ReturnBook(book2);
        Console.WriteLine("Libros prestados despues de la devolución:");
        library.DisplayBorrowedBooks();
    }
}