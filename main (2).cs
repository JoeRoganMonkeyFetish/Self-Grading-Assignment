using System;

class Program {
  public static void Main (string[] args) {

    int a,b;
  Console.WriteLine("Enter 2 numbers...");
   a= Convert.ToInt32(Console.ReadLine());
   b=Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter the option...");
   String exp =(Console.ReadLine());
    
    switch (exp)
    {
      case "+": Console.WriteLine("Addition is {0}",(a+b)); 
    break; 

      case "-": Console.WriteLine("Subtract is {0}",(a-b));
        break; 

      case "/": Console.WriteLine("Division is {0}",(a/b));
        break;

      case "%": Console.WriteLine("Modulo is {0}",(a%b));
    break;

      case "*": Console.WriteLine("Multiplication is {0}",(a*b)); 
        break; 

      default: Console.WriteLine("some other choices");
        break; 
        
    }
    }
  }
