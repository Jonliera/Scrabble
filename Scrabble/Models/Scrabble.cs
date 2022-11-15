using System;
using System.Collections.Generic;

namespace Scrabble.Models
{
  public class ScrabbleGame
  {
    public string scrabbleWord { get; set; }
    // public int wordScore;
    
    public ScrabbleGame(string word)
    {
      scrabbleWord = word;
    }
  }
}