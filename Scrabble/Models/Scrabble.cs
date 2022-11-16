using System;
using System.Collections.Generic;

namespace Scrabble.Models
{
  public class ScrabbleGame
  {
     public string scrabbleWord { get; set; }

    public ScrabbleGame(string word)
    {
      scrabbleWord = word;
    }

    private Dictionary <char, int> scoreValue = new Dictionary<char, int>()
    {
      {'A', 1}, {'B', 3}, {'C', 3}, {'D', 2},
      {'E', 1}, {'F', 4}, {'G', 2}, {'H', 4},
      {'I', 1}, {'J', 8}, {'K', 5}, {'L', 3},
      {'M', 3}, {'N',4}, {'O', 1}, {'P', 3},
      {'Q', 10}, {'R',3}, {'S', 1}, {'T', 2},
      {'U', 1}, {'V', 4}, {'W', 4}, {'X', 8},
      {'Y', 4}, {'Z', 10},
    };
    
    public int Total()
    {
      int points = 0;
      
      foreach (char character in scrabbleWord)
      {
        int pointsValue = scoreValue[character];
        points += pointsValue;
      }
      return points;
    }
  }
}

  //   // public int wordScore;
    
  //   public ScrabbleGame(string word)
  //   {
  //     scrabbleWord = word;
  //     string[] Onepoint = { "A", "E", "I", "O", "U", "L", "N", "R", "S", "T", };
  //     string[] Twopoints = { "D", "G" };
  //     string[] Threepoints = { "}
  //   }
  //   public 
  // }