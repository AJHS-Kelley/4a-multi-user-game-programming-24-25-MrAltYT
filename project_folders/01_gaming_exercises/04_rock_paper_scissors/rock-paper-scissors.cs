// Johnson T, Rock-Paper-Scissors v0.0
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
    Console.WriteLine("Is this YOUR NAME? " + playerName + "? \n\n If true, type yes");
    answer = Console.ReadLine().Uper();
    if (answer == "YES")
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