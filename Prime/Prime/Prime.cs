using System;
public class Prime 
{
   public static void Main(string[] argv)
   {
      io myio = new io();
      try
      {
         while (myio.allowedValue())
         {
            myio.test();
         }
      }
      catch (Exception myexp)
      {

         Console.WriteLine(myexp.ToString());
      }

   }
}

