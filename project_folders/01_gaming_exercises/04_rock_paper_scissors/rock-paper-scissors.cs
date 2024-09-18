// Johnson T, Rock-Paper-Scissors v0.4
using System;
class Template {
  static void Main() {

    // VARIABLES
    bool gameplay =  false;
    string playerName = "";
    string testPlayer = "";
    int playerScore = 0;
    int cpuScore = 0;
    string playerChoice = "";
    string cpuChoice = "";

    // Player Name

    Console.WriteLine("By ❤️ ⭐ RUBY-CHAN⭐ ❤️\n\n\n");
    Console.WriteLine("Please.. Input.. your NAME, then press Enter\n");
    playerName = (Console.ReadLine());
    Console.WriteLine("Is this YOUR NAME? " + playerName + "? \n\n If True, type yes\n\n");
    testPlayer = Console.ReadLine().ToLower();
    if (testPlayer == "yes")
    {
        gameplay = true;
    }
    else 
    {
        Console.WriteLine("You've ran into an error, please restart the game.\n");
    }

    // Rules of Game
    Console.WriteLine("Ruby - Welcome to Rock, Paper, Scissors. My name is Ruby, and I will be your opponet! \n" + playerName);
    Console.WriteLine("Ruby - Rock beats Scissors, Scissors beats Paper, and Paper beats Rock\n");
    Console.WriteLine("Ruby - The winner scores a point. If each player picks the same no points are awarded\n");
    Console.WriteLine("Ruby - The first player to five points wins.\n");
    Console.WriteLine("Ruby - Have FUNNN");
    
    // Start Of Game

    while (playerScore <= 5)
    {
      Console.WriteLine("Ruby - Choose between Rock, Paper, and Scissors\n");

      playerChoice = Console.ReadLine().ToLower();

      if (playerChoice == "rock")
      {
        Console.WriteLine("Your Choice is Rock\n");
      }
      if (playerChoice == "paper")
      {
        Console.WriteLine("Your Choice is paper\n");
      }
      if (playerChoice == "scissors")
      {
        Console.WriteLine("Your Choice is scissors\n");
      }
      
      Console.WriteLine("Ruby Choose.. " + cpuChoice);
      
    }


  }
}