using System;

namespace Giraffe
{
  class Book
  {
    public string title;
    public string author;
    public int pages;
    
    // when creating a new object, the constructor is called, constructor = Book()
    // by having an empty constructor, you can create a new object without having to add values
    public Book () {}
    public Book(string aTitle, string aAuthor, int aPages)
    {
      title = aTitle;
      author = aAuthor;
      pages = aPages;
    }

  }
}
