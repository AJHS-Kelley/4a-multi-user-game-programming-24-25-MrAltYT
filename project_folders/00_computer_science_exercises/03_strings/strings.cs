// Johnson Traevon strings C# v0.1
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


  
  }
}