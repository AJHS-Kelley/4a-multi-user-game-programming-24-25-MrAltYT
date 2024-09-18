// Johnson T, Rock-Paper-Scissors v0.1
using System;
class Template {
  static void Main() {

    // VARIABLES
    bool gameplay =  false;
    string playerName = "";
    string testPlayer = "";
    int playerScore;
    int cpuScore;
    string playerChoice = "";
    string cpuChoice = "";

    // Player Name

    Console.WriteLine("By ❤️ ⭐ RUBY-CHAN⭐ ❤️\n\n\n");
    Console.WriteLine("Please.. Input.. YOUR NAMEEEE\n");
    playerName = (Console.ReadLine());
    Console.WriteLine("Is this YOUR NAME? " + playerName + "? \n\n If True, type yes");
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

    Console.WriteLine("Rock beats Scissors, Scissors beats Paper, and Paper beats Rock\n");
    Console.WriteLine("The winner scores a point. If each player picks the same no points are awarded\n");
    Console.WriteLine("The first player to five points wins.\n");


  }
}