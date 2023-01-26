using System;

public class Book
{
    private string _author = "";
    private string _title = "";
    //Constructor Empty
    public Book()
    {
        _author = "Anonymous";
        _title = "Unknown Books";
    }
    public Book(string author, string title)
    {
        _author = author;
        _title = title;
    }

    public string GetBookInformation()
    {
        return $"{_title} by {_author}";
    }

    public string GetAuthor()
    {
        return _author;
    }
    public void SetAuthor(string author)
    {
        _author = author;
    }

    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }
}