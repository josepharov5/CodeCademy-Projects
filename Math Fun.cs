using System;

namespace Review
{
  class Program
  {
    static void Main(string[] args)
    {
      /* This is just me throwing some different code together and messing around with Operators, Increments and some math methods:

      DATA TYPES: int, double
      ARITHMETIC OPERATORS: +, -, *, /
      INCREMENT/DECREMENT: ++, --
      MODULO: % 
      BUILT-IN METHODS: Abs, Pow, Sqrt, Floor, Ceiling, Min, Max */
    int numberOne = 256;
    int numberTwo = 512;
    double answerOne = numberOne * numberTwo;
    Console.WriteLine(answerOne);
    //increment by one and assign new variable
    double answerTwo = answerOne + 1; 
    Console.WriteLine(answerTwo);
    //doing some math stuff and finding remainder
    double answerThree = answerOne / 3;
    Console.WriteLine(answerThree);
    double answerFour = answerOne % answerThree;
    double answerFive = answerTwo % answerThree;
    Console.WriteLine(answerFour);
    Console.WriteLine(answerFive);
    //Using math methods!
    double roundedFive = Math.Floor(answerFive);
    Console.WriteLine(roundedFive);
    double roundedThree = (Math.Ceiling((Math.Floor(answerOne)/numberOne)));
    Console.WriteLine(roundedThree);
    }
  }
}
