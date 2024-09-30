// Johnson T, Rock-Paper-Scissors v0.9
using System;
class RPS {
  static void Main() {

    // VARIABLES
    int playerScore = 0;
    int cpuScore = 0;
    string playerChoice = "";
    string rubyChoice = "";
    int numDraws = 0;
    int playerRand = 0;
    
    

    // Testing Game LOOP
    int loopCount = 0;
    int loopreqs = 0;
    Console.WriteLine("How many loops do u need?\n type an integer and press enter");
    loopreqs = Convert.ToInt32(Console.ReadLine());

    
    // Start Of Game

    while (loopCount < loopreqs)
    {
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
        Console.WriteLine(" L\n");
      }
      Console.WriteLine(" I Choose---" + rubyChoice + "\n");


        // CPU CHOICE 
      int playerRand = rnd.Next(0, 3);
      if (playerRand == 0)
      {
        playerChoice = "rock";
      }
      else if (playerRand == 1)
      {
        playerChoice = "paper";
      }
      else if (playerRand == 2)
      {
        playerChoice = "scissors";
      }
      else
      {
        Console.WriteLine(" L\n");
      }

      Console.WriteLine(" I Choose---" + rubyChoice + "\n");
      
      // Who Wins??
      // ROCK
      if (playerChoice == "rock" && rubyChoice == "paper")
      {
        Console.WriteLine(" Ha!! I WIN (BLEH)\n\n");
        cpuScore++;
        Console.WriteLine(" Your score is " + playerScore + " And mine is " + cpuScore + "\n");
      }
      else if (playerChoice == "rock" && rubyChoice == "scissors")
      {
        Console.WriteLine(" HuH!?\n\n");
        playerScore++;
        Console.WriteLine(" Your score is " + playerScore + " And mine is " + cpuScore + "\n");
      }
      else if (playerChoice == "rock" && rubyChoice == "rock")
      {
        Console.WriteLine(" Seems I met my match >c\n\n");
        Console.WriteLine(" Your score is " + playerScore + " And mine is " + cpuScore + "\n");
      }


      // PAPER
      if (playerChoice == "paper" && rubyChoice == "scissors")
      {
        Console.WriteLine(" Ha!! I WIN (BLEH)\n\n");
        cpuScore++;
        Console.WriteLine(" Your score is " + playerScore + " And mine is " + cpuScore + "\n");
      }
      else if (playerChoice == "paper" && rubyChoice == "rock")
      {
        Console.WriteLine(" HuH!?\n\n");
        playerScore++;
        Console.WriteLine(" Your score is " + playerScore + " And mine is " + cpuScore + "\n");
      }
      else if (playerChoice == "paper" && rubyChoice == "paper")
      {
        Console.WriteLine(" Seems I met my match >:c\n\n");
        Console.WriteLine(" Your score is " + playerScore + " And mine is " + cpuScore + "\n");
      }

      // SCISSORS
      if (playerChoice == "scissors" && rubyChoice == "rock")
      {
        Console.WriteLine(" Ha!! I WIN (BLEH)\n\n");
        cpuScore++;
        Console.WriteLine(" Your score is " + playerScore + " And mine is " + cpuScore + "\n");
      }
      else if (playerChoice == "scissors" && rubyChoice == "paper")
      {
        Console.WriteLine(" HuH!?\n\n");
        playerScore++;
        Console.WriteLine(" Your score is " + playerScore + " And mine is " + cpuScore + "\n");
      }
      else if (playerChoice == "scissors" && rubyChoice == "scissors")
      {
        Console.WriteLine(" Seems I met my match >c\n\n");
        Console.WriteLine(" Your score is " + playerScore + " And mine is " + cpuScore + "\n");
      }
      loopCount++;
      

    }


  }
}