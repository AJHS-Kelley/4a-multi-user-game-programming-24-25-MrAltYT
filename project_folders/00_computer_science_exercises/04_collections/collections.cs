// Youkosou to my collections for C#, made by Johnson T v0.4
using System;
using System.Linq;
using System.Collections;


class Collections {
  static void Main() {
    /*
    In C#, Collection is known as an ARRAY

    -- Each item in the array is an Element
    -- the number of elements in the array cannot be changed
    -- Contents of each element can change
    -- arrays are ordered, meaning each item has a fixed position
    -- Position of an element is called an INDEX
    -- First element in Index is 0
    */

    // Declaring and Defining an ARRAY
    string[] breakfastFoods = {"Pancake", "Bacon", "Fruit Loops", "muffin", "grammies"};
    int[] testScores = {-35, 25, 53, 72, 100};
    double[] GPA = {0.13D, 1.8D, 2.0D, 3.0D, 60.4D};

    // Print Array Contents -- All Elements on Single Line
    Console.WriteLine("Ruby: The Elements of each array are:\n");

    Console.WriteLine("Ruby: Here's your breakfastFoods: \n" + String.Join(", ", breakfastFoods));
    Console.WriteLine(); // Prints an empty line to the screen

    Console.WriteLine("Ruby: Here's your recent test scores: \n" + String.Join(", ", testScores));
    Console.WriteLine();

    // Print Array Contents -- on seperate Lines
    Console.WriteLine("Ruby: Here's your breakfastFoods: \n" + String.Join("\n ", breakfastFoods));
    Console.WriteLine(); // Prints an empty line to the screen

    Console.WriteLine("Ruby: Here's your gpa these fine semesters: \n" + String.Join("\n ", GPA));
    Console.WriteLine();

    // How long is my array? Deteremining Array Length
    Console.WriteLine("The length of the breakfastfoods array is: " + breakfastFoods.Length);
    // .Length is known as a property of the array

    // Accessing elements in the array with the index.
    Console.WriteLine("The first element in breakfastFoods is: " + breakfastFoods[0]);
    // Print the 2nd Element of the testscores and 3rd if the Gpa
    Console.WriteLine("The second element in test scores is: " + testScores[1]);
    Console.WriteLine("The third element in gpa is: " + GPA[2]);

  

  } // DO NOT DELETE EVER, SHOULD BE 3 SPACES INDENTED
} //  DO NOT DELETE EVER, ALWAYS TOUCHING LEFT MARGIN