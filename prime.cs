using System;
class CheckPrime
{
 public static void Main(string[] args)
 {
    int i,number,flag=0;
    Console.WriteLine("Enter the number:");
    number=int.Parse(Console.ReadLine());
    
      if(number == 0 || number ==1)
        flag=1;
     
    
 for( i=2;i<=number/2;i++) 
 { 
    if(number%i==0 )
   {
    flag=1;
    break;
  }
 }
   if(flag==1)
    Console.WriteLine("It is not a prime number.");
   if(flag==0)
    Console.WriteLine("It is prime number.");
   }
 }
 