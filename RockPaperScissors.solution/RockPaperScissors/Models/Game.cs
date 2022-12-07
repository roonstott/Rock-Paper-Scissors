using System;
using System.Collections.Generic;

namespace RockPaperScissors.Models
{
  public class Game 
  {
    public string Hand1 { get; }
    public string Hand2 { get; }

    public string Winner { get; set; }

    private static Dictionary<string, int> _playerWins = new Dictionary<string, int>()
    {
      {"player1", 0},
      {"player2", 0}
    };
    public Game(string hand1, string hand2)
    {
      Hand1 = hand1;
      Hand2 = hand2;
      string Winner = "tie";
    }
    public void RoundPlay()
    {
      if (Hand1 == "scissors")
      {
        if (Hand2 == "rock") {
          Winner = "player2";
        }
        else if (Hand2 == "paper") 
        {
          Winner = "player1";
        }
        else //Hand 2 == "scissors"
        {
          Winner = "tie";
        }
      }
      else if (Hand1 == "paper")
      {
        if (Hand2 == "rock") 
        {
          Winner = "player1";
        }
        else if (Hand2 == "paper") 
        {
          Winner = "tie";
        }
        else //Hand2 == "scissors"
        {
          Winner = "player2";
        }
      }
      else //Hand1 == "rock"
      {
        if(Hand2 == "rock")
        {
          Winner = "tie";
        }
        else if(Hand2 == "paper")
        {
          Winner = "player2";
        }
        else //Hand2 == "scissors
        {
          Winner = "player1";
        }
      }      
    }

    public void EnterWin() 
    {
      _playerWins[Winner] += 1;
    }

    public static Dictionary<string, int> GetDictionary()
    {
      return _playerWins;
    }

    public static string GetWinner()
    {
      if (_playerWins["player1"] == 2) 
      {
        return "player1";
      }
      else if (_playerWins["player2"] == 2)
      {
        return "player2";
      }
      else 
      {
        return "no winner yet";
      }
    }
  }
} 
