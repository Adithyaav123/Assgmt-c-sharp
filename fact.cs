using System;
class FindFactorial
{
  public static void Main(string[] args)  
   {  
     int i,factorial=1,number;      
      Console.WriteLine("Enter a number: ");      
      number= int.Parse(Console.ReadLine());     
      for(i=1;i<=number;i++){      
      factorial=factorial*i;      
     }      
       Console.WriteLine("Factorial of " +number+" is: "+factorial);    
     }  
  }  