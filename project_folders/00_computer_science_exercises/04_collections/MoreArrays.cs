// ohh the pain by Traevon Johnson v0.4
using System;
using System.Linq;
using System.Collections;

class MoreArrays {
  static void Main() {
    string[] colors = {"lavendar", "red", "black", "silver", "cyan"};
    // LOOPING THROUGH ARRAYS
    // for (int i = 0; i < colors.Length; i++)
    // {
    // Console.WriteLine(colors[i]);
    // }

    // // looping through arrays -- the new hotness
    // foreach (string i in colors)
    // {
    //     Console.WriteLine(i);
    // }

    // Looping through arrays practice
    int[] bintricalizationalism = {69, 4, 7, 17, 19};
    foreach (int i in bintricalizationalism)
        {   
            Console.WriteLine(i);
            if (i % 2 == 0)
            {
                Console.WriteLine("Ruby: this number is even");
            }
            else
            {
                Console.WriteLine("Ruby: This number is odd");
            }
        }


    // multidimensional arrays
    // This class will only be 2D
    int[,] nums = {{7, 42, 343}, {12, 14, 2}};
    
    // Accessing elements in 2D arrays
    Console.WriteLine(nums[0, 1]);
    Console.WriteLine(nums[1, 1]);

    // Changing element in 2D arrays
    nums[1, 2] = 69;
    // change any element from the first array
    nums[0, 2] = 22;

    // Looping through 2D arrays -- Easy
    foreach (int i in nums)
    {
        Console.WriteLine(i);
    }
    // looping through 2D arrays --  Hard
    for (int i = 0; i < nums.GetLength(0); i++)
    {
        for (int j = 0; j < nums.GetLength(1); j++)
        {
            Console.WriteLine(nums[i, j]);
        }
    }






  } // DO NOT DELETE EVER, SHOULD BE 3 SPACES INDENTED
} //  DO NOT DELETE EVER, ALWAYS TOUCHING LEFT MARGIN