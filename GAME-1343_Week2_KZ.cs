/* 
Kyle Zapalac
GAME-1343
28-January-2022
Description: Assignment to practice declaring variables, calculation, writing, and if statements
*/

using System;

class Program 
{
  public static void Main (string[] args) 
  {
    // declare variables
    int myVar =  7;

    // confirm myVar in code
    Console.WriteLine("\nOutput where myVar = " + myVar + ":");

    // print required outputs
    Console.WriteLine("\n"+(-1+4*myVar));
    Console.WriteLine((35+5)%myVar);
    Console.WriteLine(14+-4*6/12);
    Console.WriteLine(2+12/6*1-myVar%2);
    
    // if statment print
    if((myVar*myVar)>10)
    {
      Console.WriteLine("\nmyVar is greater than 4");
    }
    else
    {
      Console.WriteLine("\nmyVar is less than 4");
    }

  }
}