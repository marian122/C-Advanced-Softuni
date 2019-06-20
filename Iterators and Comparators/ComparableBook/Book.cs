using System;
using System.Collections.Generic;
using System.Text;

public class Book : IComparable<Book>
{
    private List<string> authors;
    public Book(string title, int year, params string[] authors)
    {
        this.Title = title;
        this.Year = year;
        this.authors = new List<string>(authors);
    }

    public string Title { get; set; }

    public int Year { get; set; }

    public IReadOnlyCollection<string> Authors
    {
        get
        {
            return this.authors.AsReadOnly();
        }
    }

    public int CompareTo(Book otherBook)
    {
        int result = this.Year.CompareTo(otherBook.Year);

        if (result != 0)
        {
            return result;
        }
        return this.Title.CompareTo(otherBook.Title);
    }
    public override string ToString()
    {
        return $"{this.Title} - {this.Year}";
    }
}


