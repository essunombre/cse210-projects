public class Reference
{
    //private attributes
    private string _book;
    private int _chapter;
    private int _verse;
    private int _verseTo;

    //Constructor that has  only one verse.
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int verse, int verseTo)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _verseTo = verseTo;
    }
    // Create getters and setters
    public string GetBook()
    {
        return _book;
    }
    public void SetBook(string book)
    {
        _book = book;
    }
    public int GetChapter()
    {
        return _chapter;
    }
    public void SetChapter(int chapter)
    {
        _chapter = chapter;
    }
    public int GetVerse()
    {
        return _verse;
    }
    public void SetVerse(int verse)
    {
        _verse = verse;
    }
    public int GetVerseTo()
    {
        return _verseTo;
    }
    public void SetVerseto(int verseTo)
    {
        _verseTo = verseTo;
    }
    public string GetReferenceString()
    {
        return $"{_book} {_chapter}:{_verse}";
    }

}