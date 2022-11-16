using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;
using System;

namespace Scrabble.Tests
{
  [TestClass]
  public class ScrabbleGameTests
  {
    [TestMethod]
    public void ScrabbleGame_CreatesInstanceOfString_String()
    {
      // Arrange
      string testString = "hey";
      ScrabbleGame newGame = new ScrabbleGame(testString);
      // Act
      // Assert
      Assert.AreEqual(typeof(string), newGame.scrabbleWord.GetType());
    }

    [TestMethod]
    public void ScrabbleGame_ReturnPointsFromString_Int()
    {
      // Arrange
      int num = 1;
      string testString = "U";
      ScrabbleGame newGame = new ScrabbleGame(testString);
      // Act
      // Assert
      Assert.AreEqual(num, newGame.Total());
    }
  }
}