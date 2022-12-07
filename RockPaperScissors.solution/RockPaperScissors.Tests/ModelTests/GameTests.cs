using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Models;

namespace RockPaperScissors.Tests
{
  [TestClass]
  public class GameTests
  {
    [TestMethod]
    public void GameConstructor_CreatesInstanceOfGame_Game()
    {
      Game newGame = new Game("rock", "scissors");
      Assert.AreEqual(typeof(Game), newGame.GetType());
    }

    [TestMethod]
    public void GameConstructor_AssignsPlayerHands_String()
    {
      string hand1 = "scissors";
      string hand2 = "rock";
      Game newGame = new Game(hand1, hand2);
      string result = newGame.Hand1;
      Assert.AreEqual(result, hand1);
      // Assert.AreEqual(newGame.hand2, "rock");
    }

    [TestMethod]
    public void RoundPlay_DeterminesPlayerWon_String()
    {
      string hand1 = "scissors";
      string hand2 = "paper";
      Game newGame = new Game(hand1, hand2);
      newGame.RoundPlay();
      string result = newGame.Winner;
      Assert.AreEqual("player1", result);
    }

    [TestMethod]

    public void GetDictionary_ReturnsEmptyDictionary_Dictionary()
    {
      Dictionary<string, int> newDictionary = new Dictionary<string, int>() {{"player1", 0}, {"player2", 0}};
      Dictionary<string, int> result = Game.GetDictionary();
      CollectionAssert.AreEqual(newDictionary, result);
    }

    [TestMethod]

    public void EnterWin_ReturnsPlayerWins_UpdatedDictionary()
    {
      string hand1 = "scissors";
      string hand2 = "paper";
      Game newGame = new Game(hand1, hand2);
      newGame.RoundPlay();
      newGame.EnterWin();
      Dictionary<string, int> newDictionary = new Dictionary<string, int>() {{"player1", 1}, {"player2", 0}};
      Dictionary<string, int> result = Game.GetDictionary();
      CollectionAssert.AreEqual(newDictionary, result);
    }

    [TestMethod]
    public void GetWinner_ReturnsGameWinner_String()
    {
      string hand1 = "scissors";
      string hand2 = "rock";
      Game newGame = new Game(hand1, hand2);
      newGame.RoundPlay();
      newGame.EnterWin();
      string result = Game.GetWinner();
      string compare = "no winner yet";
      // Dictionary<string, int> newDictionary = new Dictionary<string, int>() {{"player1", 2}, {"player2", 0}};
      // Dictionary<string, int> result = Game.GetDictionary();
      Assert.AreEqual(compare, result);

    }
  }
}