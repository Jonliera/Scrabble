using System;
using System.Collections.Generic;
using Scrabble.Models;

namespace Scrabble.Models {
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("-----------------");
      Console.WriteLine("Scrabble Scorer! Enter A Word And See What Your Score Is!");
      RunInput();
    }

    public static void RunInput()
    {
      Console.WriteLine("What is your word?");
      string wordInput = Console.ReadLine();
      if (checkerFunct(wordInput) == true)
      {
        ScrabbleGame newGame = new ScrabbleGame(wordInput.ToUpper());
        int wordResult = newGame.Total();
        Console.WriteLine("Your word: " + wordInput + " scored " + wordResult + " points.");
      }
      else
      {
        Console.WriteLine("1 word inputs only!");
        RunInput();
      }
    }

    public static bool checkerFunct(string wordInput)
    {
      foreach (char letter in wordInput)
      {
        if (char.IsLetter(letter) != true)
        {
          return false;
        }
      }
      return true;
    }
  }
}