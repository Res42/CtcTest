using System;
public class io
{
   int myvalue;
    
   public bool allowedValue() //check if Value is an Integer && !0
   {
      Console.Write("Enter a number (0 to quit programm): ");
      myvalue = Int32.Parse(Console.ReadLine());
      if (myvalue != 0)
            return true;
      return false;
   }


   public void test()
   {
      if (Calc.isPrime(myvalue))
         Console.WriteLine(this.myvalue + " IS  a prime");
      else
         Console.WriteLine(this.myvalue + " IS NOT a prime");
   }
   
}

