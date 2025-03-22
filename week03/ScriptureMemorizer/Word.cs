// Purpose: Contains the Word class, which represents a word in the game. The class contains a text field, a field to determine if the word is hidden, a constructor, a method to hide the word, a method to show the word, a method to check if the word is hidden, and a method to get the display text of the word.
// The Word class is used in the Scripture class to represent the words in the scripture text.
using System;

public class Word // Word class
{
    private string _text; // Text field
    private bool _isHidden;

    public Word(string text)
    {
        _text = text; // Set the text field to the text parameter
        _isHidden = false;  // Set the isHidden field to false
    }

    public void Hide()
    {
        _isHidden = true; // Set the isHidden field to true
    }

    public void Show()
    {
        _isHidden = false; // Set the isHidden field to false
    }

    public bool IsHidden()
    {
        return _isHidden; // Return the isHidden field
    }

    public string GetDisplayText()
    {
        return _isHidden ? new string('_', _text.Length) : _text; // Return the text field if the word is not hidden, otherwise return a string of underscores with the same length as the text
    }
}

