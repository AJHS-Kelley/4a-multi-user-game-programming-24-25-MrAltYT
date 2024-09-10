// Johnson Traevon strings C# v0.2
using System;
class Template {
  static void Main() {
    // In C# ALL STRINGS MUST USE DOUBLE-QUOTES " "
    sting greeting = "Konnichiwa!! ii tenki desu ne?\n";
    sting goodbye = "Matane!!\n";

    // In C# strings are treated like an OBJECT that has properties and methods
    // Properties -- things that describe the object such as length, values, data type, etc.
    // Methods -- built in functions related to that object

    // Length is an important property for strings
    Console.WriteLine(greeting.Length);
    Console.WriteLine(goodbye.Length);

    if (greeting.Length > goodbye.Length) {
        Console.WriteLine("Aw, Your not coming back?");
    }

    // Usefull String Methods

    Console.WriteLine(greeting.ToUpper()); // make entire string upper case
    Console.WriteLine(goodbye.ToLower()); // make entire string lower case

    // String Concatenation "Con Cat Uh Nation"
    string comboString = greeting + goodbye;
    Console.WriteLine(comboString);

    // String Concatenation Method 2
    string comboString2 = string.Concat(greeting, goodbye,);
    Console.WriteLine(comboString2);

    // String Interpolation --  Subsituting variables into strings
    string comboString3 = $"My greeting is {greeting} and my goodbye is {goodbye}";
    Console.WriteLine(comboString3);

    // String Interpolation --  Subsituting variables into strings Method 2
    Console.WriteLine("My greeting is " + comboString3 + "and my goodbye is " + goodbye + "\n.");

    //Accessing parts of strings
    // index is a specific location of a character in a strong
    // ALL string indexes start at
     
     Console.WriteLine(goodbye[0]); // Print the character at index 0 
     Console.WriteLine(goodbye[4]); // print the 5th character in your index
     
     // Where is it in my string?
     Console.WriteLine(greeting.IndexOf("y"));



  
  }
}