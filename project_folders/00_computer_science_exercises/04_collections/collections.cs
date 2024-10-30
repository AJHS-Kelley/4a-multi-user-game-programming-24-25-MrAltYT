// Youkosou to my collections for C#, made by Johnson T v0.2
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
  
  } // DO NOT DELETE EVER, SHOULD BE 3 SPACES INDENTED
} //  DO NOT DELETE EVER, ALWAYS TOUCHING LEFT MARGIN