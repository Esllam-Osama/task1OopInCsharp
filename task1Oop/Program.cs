namespace task1Oop
{
  class Book
  {
    private string title;
    private string author;
    private string isBn;
    private bool availiblity = true;
    public string getTitle() { return title; }
    public void setTitle(string title) { this.title = title; }
    public string getAuthor() { return author; }
    public void setAuthor(string author) { this.author = author; }
    public string getIsBn() { return isBn; }
    public void setIsbn(string isBn) { this.isBn = isBn; }
    public bool getAvailiblity() { return availiblity; }
    public void setAvailiblity(bool availiblity) { this.availiblity = availiblity; }
  }
  class Library
  {
    private List<Book> book = new List<Book>();
    public void addBook(Book book)
    {
      this.book.Add(book);
    }
    public void borrowBook(string keyWordSearch)
    {
      bool findBook = false;
      foreach (Book book in this.book)
      {
        //search by title and author
        if (book.getTitle().Contains(keyWordSearch) || book.getAuthor().Contains(keyWordSearch))
        {
          findBook = true;
          if (book.getAvailiblity() == true)
          {
            Console.WriteLine("you can take him");
            book.setAvailiblity(false);
            return;
          }
          else
          {
            Console.WriteLine("sorry this book is Unavailable");
          }
        }

      }
      if (!findBook) { Console.WriteLine("sorry book is not defind..!"); }
    }
    public void returnBook(string keyWordSearch)
    {
      bool findBook = false;
      foreach (Book book in this.book)
      {
        //search by title and author
        if (book.getTitle().Contains(keyWordSearch) || book.getAuthor().Contains(keyWordSearch))
        {
          findBook = true;
          if (book.getAvailiblity() == false)
          {
            Console.WriteLine("Thx book is returned");
            book.setAvailiblity(true);
            return;
          }
          else
          {
            Console.WriteLine("This book has been in the library..!");

          }
        }

      }

      if (findBook == false) { Console.WriteLine("sorry book is not defind"); }
    }

  }
  internal class Program
  {
    static void Main(string[] args)
    {
      Library library = new Library();
      // Declare books
      Book book1 = new Book();
      book1.setTitle("The Great Gatsby");
      book1.setAuthor("F. Scott Fitzgerald");
      book1.setIsbn("9780743273565");

      Book book2 = new Book();
      book2.setTitle("To Kill a Mockingbird");
      book2.setAuthor("Harper Lee");
      book2.setIsbn("9780061120084");

      Book book3 = new Book();
      book3.setTitle("1984");
      book3.setAuthor("George Orwell");
      book3.setIsbn("9780451524935");

      // Adding books to the library
      library.addBook(book1);
      library.addBook(book2);
      library.addBook(book3);

      //borrow
      library.borrowBook("Gatsby");
      library.borrowBook("Gatsby");
      library.borrowBook("1984");
      library.borrowBook("Harry Potter");//this book is not in the library

      //return books
      library.returnBook("Gatsby");
      library.returnBook("Harry Potter"); // This book is not borrowed
    }
  }
}
