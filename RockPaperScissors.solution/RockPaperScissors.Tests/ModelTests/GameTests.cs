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
      Game newGame = new Game();
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
  }
}