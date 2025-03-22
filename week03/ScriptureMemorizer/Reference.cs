// Purpose: The Reference class is used to store the book, chapter, and verse of a scripture reference. It also has a method to return the reference in a displayable format.
// The Reference class is used in the Scripture class to store the reference of the scripture.
using System;
using System.Collections.Concurrent;

public class Reference // Reference class
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;


    public Reference(string book, int chapter, int verse) // Reference constructor
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse) // Reference constructor
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

 
    public string GetDisplay() // GetDisplay method
    {
        return _verse == _endVerse ? 
            $"{_book} {_chapter}:{_verse}" : 
            $"{_book} {_chapter}:{_verse}-{_endVerse}";
    }
}
