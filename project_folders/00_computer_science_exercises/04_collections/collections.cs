// Youkosou to my collections for C#, made by Johnson T v0.6
using System;
using System.Linq;
using System.Collections;


class Collections {
  static void Main() {
    bool allMobsHostile = false;
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
    // string[] breakfastFoods = {"Pancake", "Bacon", "Fruit Loops", "muffin", "grammies"};
    // int[] testScores = {-35, 25, 53, 72, 100};
    // double[] GPA = {0.13D, 1.8D, 2.0D, 3.0D, 60.4D};

    // // Print Array Contents -- All Elements on Single Line
    // Console.WriteLine("Ruby: The Elements of each array are:\n");

    // Console.WriteLine("Ruby: Here's your breakfastFoods: \n" + String.Join(", ", breakfastFoods));
    // Console.WriteLine(); // Prints an empty line to the screen

    // Console.WriteLine("Ruby: Here's your recent test scores: \n" + String.Join(", ", testScores));
    // Console.WriteLine();

    // // Print Array Contents -- on seperate Lines
    // Console.WriteLine("Ruby: Here's your breakfastFoods: \n" + String.Join("\n ", breakfastFoods));
    // Console.WriteLine(); // Prints an empty line to the screen

    // Console.WriteLine("Ruby: Here's your gpa these fine semesters: \n" + String.Join("\n ", GPA));
    // Console.WriteLine();

    // // How long is my array? Deteremining Array Length
    // Console.WriteLine("The length of the breakfastfoods array is: " + breakfastFoods.Length);
    // // .Length is known as a property of the array

    // // Accessing elements in the array with the index.
    // Console.WriteLine("The first element in breakfastFoods is: " + breakfastFoods[0]);
    // // Print the 2nd Element of the testscores and 3rd if the Gpa
    // Console.WriteLine("The second element in test scores is: " + testScores[1]);
    // Console.WriteLine("The third element in gpa is: " + GPA[2]);

    // Sorting arrays
    // finding min, max, and sum for arrays

    //ArrayList --> An array you can add/remove elements from.
    var exampleArrList = new ArrayList(); // creates new array list.
    // Adding elements to a array list use .Add()
    exampleArrList.Add(6);
    exampleArrList.Add("The Flash the showdown vs hulk");
    exampleArrList.Add(false);
    exampleArrList.Add(3.0D);

    // create arraylist with values
    var exampleArrList2 = new ArrayList()
      {
        -20, "Hoshino", "Pinkish Red", "True", 13.5D, 1942, 1.8D
      }; 
      // Console.WriteLine(exampleArrList[2]);
      // Console.WriteLine(exampleArrList2[1]);

      // inserting to a specific position in the array list
      // use .Insert(index, value)
      // exampleArrList.Insert(4, "I love stars");
      // exampleArrList2.Insert(3, "aww");

      // .Remove(value) removes the first occurence of the item from the array list.
      var newList = new ArrayList()
      {
        -10, 20, 35, 66, 23, 79, -10, -60, -60
      };
    // Console.WriteLine(newList[0]);
    // newList.Remove(-10);
    // Console.WriteLine(newList[0]);
    
    // // Deleting based off index number
    // // .RemoveAt(value) -- > deletes the item at the specific index
    // newList.RemoveAt(3);

    // // deleting the first item
    // newList.RemoveAt(0);

    // // delete the last itme
    // newList.RemoveAt(newList.Length - 1);

    // // Remove an entire range of elements.
    // // .RemoveRange(first index, last index)
    // newList.RemoveRange(3, 8)

    // // shortcut to delete from  one item through the end of a list
    // newList.RemoveRange(4, newList.Length - 1);

    // Does the ArrayList contain a certain value
    // .Contains (value) returns true if the list has that value, false otherwise
    var playerInv = new ArrayList()
    {
      "Star", "Barrier", "supreme light", "the cocktail", "plushie", "key"
    };

    Console.WriteLine(playerInv.Contains("lightstick"));
    Console.WriteLine(playerInv.Contains("Star"));

    if (playerInv.Contains("Star"))
    {
      allMobsHostile = true;
    }



  } // DO NOT DELETE EVER, SHOULD BE 3 SPACES INDENTED
} //  DO NOT DELETE EVER, ALWAYS TOUCHING LEFT MARGIN