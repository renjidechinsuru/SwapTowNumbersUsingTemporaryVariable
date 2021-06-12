using System;

namespace SwapTowNumbersUsingTemporaryVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, temp;
            Console.WriteLine("Please enter first number");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter second number");
            number2 = Convert.ToInt32(Console.ReadLine());
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine("After Swapping :");
            Console.WriteLine("First Number : " + number1);
            Console.WriteLine("Second Number : " + number2);
            Console.ReadLine();

        }
    }
}
