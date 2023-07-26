using System;
class FindReverse
{
 public static void Main(string[] args)
{
  int number;
  int reverse=0;
  int remainder;
  Console.WriteLine("Enter a number:");
  number=int.Parse(Console.ReadLine());
  while(number!=0)
   {
      remainder=number%10;
      reverse=reverse*10+remainder;
      number/=10;
    }
    Console.WriteLine("Reverse is:"+reverse);
}
}