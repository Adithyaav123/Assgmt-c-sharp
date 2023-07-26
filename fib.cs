using System;
class PrintFibonacci
{
 public static void Main(string[] args)
{
  int numberOfTerms=8,firstNumber=1,secondNumber=1;
  
  Console.WriteLine("fibonacci upto 8 terms:");
  for (int i=0;i<numberOfTerms;++i)
  {
    Console.WriteLine(firstNumber);
    int thirdNumber=firstNumber+secondNumber;
    firstNumber=secondNumber;
    secondNumber=thirdNumber;
  }
}
}