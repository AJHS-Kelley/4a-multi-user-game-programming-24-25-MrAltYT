// Johnson T, Rock-Paper-Scissors v0.9
using System;
class RPS {
  static void Main() {

    // VARIABLES
    bool gameplay =  false;
    string playerName = "";
    string testPlayer = "";
    int playerScore = 0;
    int cpuScore = 0;
    string playerChoice = "";
    string rubyChoice = "";
    
    

    // Testing Game LOOP
    int loopcount = 0;
    int loopreqs = 0;

    
    // Start Of Game

    while (playerScore <= 5 || cpuScore <= 5)
    {
      
      
      Console.WriteLine("Ruby - Choose between Rock, Paper, or Scissors\n");

      playerChoice = Console.ReadLine().ToLower();

      if (playerChoice == "rock")
      {
        Console.WriteLine("Ruby: Your Choice is Rock\n");
      }
      if (playerChoice == "paper")
      {
        Console.WriteLine("Ruby: Your Choice is paper\n");
      }
      if (playerChoice == "scissors")
      {
        Console.WriteLine("Ruby: Your Choice is scissors\n");
      }

      // CPU CHOICE 
      Random rnd = new Random();
      int rubyRand = rnd.Next(0, 3);
      if (rubyRand == 0)
      {
        rubyChoice = "rock";
      }
      else if (rubyRand == 1)
      {
        rubyChoice = "paper";
      }
      else if (rubyRand == 2)
      {
        rubyChoice = "scissors";
      }
      else
      {
        Console.WriteLine("Ruby: L\n");
      }
      Console.WriteLine("Ruby: I Choose---" + rubyChoice + "\n");
      
      // Who Wins??
      // ROCK
      if (playerChoice == "rock" && rubyChoice == "paper")
      {
        Console.WriteLine("Ruby: Ha!! I WIN (BLEH)\n\n");
        cpuScore++;
        Console.WriteLine("Ruby: Your score is " + playerScore + " And mine is " + cpuScore + "\n");
      }
      else if (playerChoice == "rock" && rubyChoice == "scissors")
      {
        Console.WriteLine("Ruby: HuH!?\n\n");
        playerScore++;
        Console.WriteLine("Ruby: Your score is " + playerScore + " And mine is " + cpuScore + "\n");
      }
      else if (playerChoice == "rock" && rubyChoice == "rock")
      {
        Console.WriteLine("Ruby: Seems I met my match >:c\n\n");
        Console.WriteLine("Ruby: Your score is " + playerScore + " And mine is " + cpuScore + "\n");
      }


      // PAPER
      if (playerChoice == "paper" && rubyChoice == "scissors")
      {
        Console.WriteLine("Ruby: Ha!! I WIN (BLEH)\n\n");
        cpuScore++;
        Console.WriteLine("Ruby: Your score is " + playerScore + " And mine is " + cpuScore + "\n");
      }
      else if (playerChoice == "paper" && rubyChoice == "rock")
      {
        Console.WriteLine("Ruby: HuH!?\n\n");
        playerScore++;
        Console.WriteLine("Ruby: Your score is " + playerScore + " And mine is " + cpuScore + "\n");
      }
      else if (playerChoice == "paper" && rubyChoice == "paper")
      {
        Console.WriteLine("Ruby: Seems I met my match >:c\n\n");
        Console.WriteLine("Ruby: Your score is " + playerScore + " And mine is " + cpuScore + "\n");
      }

      // SCISSORS
      if (playerChoice == "scissors" && rubyChoice == "rock")
      {
        Console.WriteLine("Ruby: Ha!! I WIN (BLEH)\n\n");
        cpuScore++;
        Console.WriteLine("Ruby: Your score is " + playerScore + " And mine is " + cpuScore + "\n");
      }
      else if (playerChoice == "scissors" && rubyChoice == "paper")
      {
        Console.WriteLine("Ruby: HuH!?\n\n");
        playerScore++;
        Console.WriteLine("Ruby: Your score is " + playerScore + " And mine is " + cpuScore + "\n");
      }
      else if (playerChoice == "scissors" && rubyChoice == "scissors")
      {
        Console.WriteLine("Ruby: Seems I met my match >:c\n\n");
        Console.WriteLine("Ruby: Your score is " + playerScore + " And mine is " + cpuScore + "\n");
      }
      

    }


  }
}