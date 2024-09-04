using System;
class Template {
  static void Main() {

    int hearts = 3;
    int A = 10000;
    int B = 10001;
    int C = 100000;
    int points = 0
    Console.WriteLine("Your Points")
    Console.ReadLine("");
    

    if (points < A)
    {
        hearts -= 1;
    }    

    if (points >= B && points < C)
    {
        hearts += 1;
    }
        
    if (points > C)
    {
        hearts += 2;
    }

    else
    {
         Console.WriteLine("You suck.. retry by inputting a number please." + hearts);
    }
    
  
  }
}