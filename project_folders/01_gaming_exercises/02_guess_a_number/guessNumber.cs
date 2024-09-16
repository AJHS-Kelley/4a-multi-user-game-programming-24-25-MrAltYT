// 4A Johnson Traevon, Number Guess, v1
using System;
class GuessNumber {
  static void Main() {
    int numGuess = 0;
    int maxGuess = 10;
    int guess;

    // Generate the secret number here.
    Random rnd =  new Random(); // Create an object named 'rng' that is a copy of the Random() class.
    int hehehehaw = rnd.Next(1, 1000001); // generate from 1 to 9 (MIN to MAX)

    while (numGuess <= maxGuess) {
      Console.WriteLine("Please guess a number between 1 through 1000000\n");
      guess = Convert.ToInt32(Console.ReadLine());
      // Console.WriteLine(guess);

      numGuess++;
      Console.WriteLine("you have " + (maxGuess - numGuess) + " guesses Remaining.");
      if (guess < hehehehaw)
      {
        Console.WriteLine("Your guess is too low");
      }
      else if (guess > hehehehaw)
      {
        Console.WriteLine("Your guess is too high");
      }
      else
      {
        Console.WriteLine("Whoa.. waku waku!! You Guessed it");
        break; // keyword to exit a loop
      }

      if (numGuess >=  10)
      {
        Console.WriteLine("You have lost the game.\n please restart\n The Secret Number is...\n" + hehehehaw);
        
        
      }


    }
      // Allow the user to guess the number.
      // Compare the guess to the secret number.
      // If match, print win, if > or <, give hint.
      // +1 to numGuess
      // Check if run out of guesses (NumGuess > Max Guesses)
      // If true print a "you lose" message, if false guess again.




      
  }
}