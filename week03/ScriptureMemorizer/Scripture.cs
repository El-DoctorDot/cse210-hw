// Purpose: This file contains the Scripture class which is used to represent a scripture object. The scripture object contains a reference and a list of words. The class contains a constructor to create a new scripture object with a reference and text. The class also contains methods to hide a random number of words in the scripture, display the scripture text with the reference, and determine if all the words in the scripture are hidden.
// The Scripture class is used in the Program class to create and manipulate scripture objects.
using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    // This constructor is used to create a new scripture object with a reference and text.
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        
        foreach (var word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

  // This method is used to hide a random number of words in the scripture.
    public void HideRandomWords(int numberToHide)
    {
        var random = new Random(); // Random number generator
        List<int> availableIndexes = new List<int>();
        for (int i = 0; i < _words.Count; i++) // Loop through all the words in the scripture
        {
           if(!_words[i].IsHidden()) // Check if the word is not hidden
           {
               availableIndexes.Add(i); // Add the index to the available indexes
           }
        }
        if (availableIndexes.Count > 0) // Check if there are words available to hide
        {
            for (var i = 0; i < numberToHide && availableIndexes.Count > 0; i++) // Loop through the number of words to hide
            {
                int index = random.Next(availableIndexes.Count); // Randomly select an index
                _words[availableIndexes[index]].Hide(); // Hide the word at the selected index
                availableIndexes.RemoveAt(index); // Remove the index from the available indexes
            }
        }
    }
    
    // This method is used to display the scripture text with the reference.
    
    public string GetDisplayText()
    {
        return $"{_reference.GetDisplay()}\n{string.Join(" ", _words.ConvertAll(word => word.GetDisplayText()))}";
    }

    // This method is used to determine if all the words in the scripture are hidden.
    public bool IsCompletelyHidden() 
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}

