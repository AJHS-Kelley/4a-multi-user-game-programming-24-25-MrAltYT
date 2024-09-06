// 4A Johnson Traevon, Number Guess, v0.1
using System;
class GuessNumber {
  static void Main() {
    int numGuess = 0;
    int maxGuess = 5;
    int guess;

    // Generate the secret number here.
    Random rnd =  new Random(); // Create an object named 'rng' that is a copy of the Random() class.
    int hehehehaw = rnd.Next(1, 1001); // generate from 1 to 9 (MIN to MAX)

    while (numGuess < maxGuess) {
      Console.WriteLine("Please guess a number between 1 through 1000");
      guess = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine(guess);
      numGuess++;

    }
      // Allow the user to guess the number.
      // Compare the guess to the secret number.
      // If match, print win, if > or <, give hint.
      // +1 to numGuess
      // Check if run out of guesses (NumGuess > Max Guesses)
      // If true print a "you lose" message, if false guess again.




      
  }
}