public class Reference  
{  
    private string _book;      // The book of scripture  
    private int _chapter;      // The chapter number  
    private int _verse;        // The starting verse number  
    private int _endVerse;     // The optional end verse number  
    
    // Constructor for a single verse  
    public Reference(string book, int chapter, int verse)  
        : this(book, chapter, verse, 0) // Default for single verse  
    {  
    }  

    // Constructor for a range of verses  
    public Reference(string book, int chapter, int startVerse, int endVerse)  
    {  
        _book = book;  
        _chapter = chapter;  
        _verse = startVerse;  
        _endVerse = endVerse; // Store the end verse (default can be 0)  
    }  

    public string GetDisplayText()  
    {  
        if (_endVerse > 0)  
        {  
            return $"{_book} {_chapter}:{_verse}-{_endVerse}"; // "Book Chapter:Verse-EndVerse"  
        }  
        else  
        {  
            return $"{_book} {_chapter}:{_verse}"; // "Book Chapter:Verse"  
        }  
    }  
}