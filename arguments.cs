using System;
class CommandLineArgument{
  public static void Main(string[] args){
    int sum=0;
    int average=0;
    int count=args.Length;
    int temp=0;
    int [] arr=new int[10];
    Console.WriteLine("count is:"+args.Length);
    for(int i=0;i<count;i++)
    {
        arr[i]=Convert.ToInt32(args[i]);
        Console.WriteLine(args[i]);
     }
    for(int i=0;i<count;i++)
    {
      sum +=arr[i];
     }
    Console.WriteLine("sum:"+sum);
    average=sum/args.Length;
    Console.WriteLine("average:"+average);
    for (int i=0;i<count;i++)
    {
      for(int j=i+1;j<count;j++)
       {
        if (arr[i]>arr[j])
          {
            temp=arr[i];
            arr[i]=arr[j];
            arr[j]=temp;
           }
        }
      }
  Console.WriteLine("Maximum:"+arr[count-1]);
  Console.WriteLine("Minimum:"+arr[0]);
}
}
