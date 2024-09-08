namespace cs_netcore_project_hello;

public static class MathHelper
{
    // Method to calculate the factorial of a number
    public static int Factorial(int number)
    {
        if (number <= 1) return 1;
        return number * Factorial(number - 1);
    }

    // Method to check if a number is prime
    public static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
}
