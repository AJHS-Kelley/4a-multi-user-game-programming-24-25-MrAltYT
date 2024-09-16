// Johnson T, Rock-Paper-Scissors v0.1
using System;
class Template {
  static void Main() {

    // VARIABLES
    bool gameplay =  false;
    string playerName = "";
    string answer = "";


    // Player Name
    Console.WriteLine("By RUBY-CHAN\n\n\n");
    Console.WriteLine("Please.. Input.. YOUR NAMEEEE\n");
    playerName = (Console.ReadLine());
    Console.WriteLine("Is this YOUR NAME? " + playerName + "? \n\n If True, type yes");
    answer = Console.ReadLine().ToLower();
    if (answer == "yes")
    {
        gameplay = true;
    }
    else 
    {
        Console.WriteLine("You've ran into an error, please restart the game.");
    }
    // Start of Game

  }
}