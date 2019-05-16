public class Calc
{
   public static bool isPrime(int value)
   {
    int divisor;

    if (value == 1 || value == 2 || value == 3)
        return true;
    
    if (value % 2 == 0)
        return false;

    for (divisor = 3; divisor < value / 2; divisor += 2)
    {
        if (value % divisor == 0)
            return false;
    }

    return true;
   }

}

