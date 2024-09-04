// Data Types and Operators, Johnson Traevon, v0.3
using System;
class DataTypesOperators{
  static void Main() {
    //testing 
    /* 
    well thats something we never had in python huh
    */
    // Data Types
    // C# is Statically Typed -- once given a data type, it cannot change

    // Float -  float-- decimal numbers. +/- including 0.0
    
    // Double -  double -- decimal numbers, +/-, including 0.0 <-- most commonly used decimal

    // integer - int -- whole numbers, +/-, including 0

    // Variables are 'buckets' with a name to store data inside

    // Declaring (creating variables)
    // method #1 -- declared but not assigned 
    // dataType varriableName;

    int stars;
    double galaxies;

    //method #2 -- Delcare and assign
    int nerula = 1;

    double oshi = 6.0D;

    // string -- collections of letters, numbers, special characters.
    string geometryDash = "This is my fav game";

    // Booleans -- bool - True or False values
    bool sharp = false;
    bool deathCounter = false;
    bool clickedCorrectKey = false;

    // character -- char -- a single character
    char AiHoshino = 'AiHoshino';

    // assigning values after declaration

    sharp = true;
    deathCounter = true;
    clickedCorrectKey = true;
    oshi = 3.0D;

    
    // printing variables to the console terminal
    // Console.Write.Line(nerula);
    // Console.Write.Line(oshi);

    // Console.Write.Line(nerula - 1);
    // Console.Write.Line(oshi + 1.0D);

    // Console.Write.Line(nerula);
    // Console.Write.Line(oshi);

    // operator -- arithemetic

    // addition
    int shine = shine + light;
    double sparkle = sparkle + rate;

    double charAffects = sparkle + shine;

    // subtraction
    int leftovers = nerula - 1;

    // division
    int ranNumb = 2 / nerula;

    // multiplication
    int nanNil = nerula * 2; 

    // Modulus -- divides, then returns the remainder
    // Mostly commonly used to determine even or odd
    nagomi = oshi % 2;

    int colleages = 3;
    int dividen = 6;
    int whatsleft;

    whatsleft = dividen % colleages;
    
    // Increment/ Decrement -- Most frequently used in LOOPS
    int x = 0;
    x++; // what is x equal to now
    // Increment ++ adds 1 to the current value and puts new value into the bucket
    x--;
    // Decrement -- subtracts by 1 from the current value and puts the new value into the bucket

    // Special Assighnment Operator
    x += 1;
    x *= 1;
    x /= 1;
    x -= 1;
    x %= 1;
    // Take current value, performs the calculation, put the new value into the bucket

    // Comparison Operators
    // evalute the expression, return true or false
    int y = 5;
    int z = 3;

    // // is-equal == is the value on the left equal to the value on the right
    // Console.WriteLine(y == z);

    // // not equal to != is the value on the left not equal to the right
    // Console.WriteLine(y != z);

    // // Greater than >
    // Console.WriteLine(y > z);

    // // greater than or equal to >=
    // Console.WriteLine(y >= z);

    // // less than <
    // Console.WriteLine(y < z);

    // // less than or equal to <=
    // Console.WriteLine(y <= z);

    // // Logical Operators
    // int b = 1;
    // double c = 2.0D;
    // string favColor = "Red"

    // // logical and && -- all statements must be true
    // Console.WriteLine(b > 1 && c != 5.0D); // false becuz b isnt equal to 1
    // Console.WriteLine(b == 1 && c < 10.0D); // both are true, everything is true
    // // if one expression most likely to be false, check for it first
    
    // // logical or || -- one statement must be true
    // Console.WriteLine(b > 1 || c !=5.0D); // this is true becuz C is under 5
    // Console.WriteLine(b == 2 || c > 10); // this is false since both are false
    // // Check for the statement most likely to be true first

    // Logical Not ! -- Returns the opposite value of the expression
    Console.WriteLine(b > -1); // True
    Console.WriteLine(!(b > -1)); // True

 


    




  }
}