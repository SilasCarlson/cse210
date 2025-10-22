using System.Collections.Concurrent;

class Reference
{
    private string _book;
    private int _chapter;
    private int _firstVerse;
    private int _lastVerse;

    public Reference(string book, int chapter, int firstVerse, int lastVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _lastVerse = lastVerse;
    }

    public string GetContent()
    {
        // ex. John 3:16
        if (_firstVerse == _lastVerse)
        {
            return $"{_book} {_chapter}:{_firstVerse}";
        }
        
        // ex. 3 Nephi 18:1-11
        return $"{_book} {_chapter}:{_firstVerse}-{_lastVerse}";
    }
}