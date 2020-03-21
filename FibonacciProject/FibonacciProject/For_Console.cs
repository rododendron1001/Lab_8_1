using System;
using System.Collections.Generic;
using System.Text;

namespace FibonacciProject
{
    class For_Console
    {
        public static int ReadNumber(string message, int maxAttempts, int defaultValue)
        {
            int attemptsCount = 1;
            bool isNumber = false;

            while (!isNumber)
            {
                Console.Write(message);
                string text = Console.ReadLine();

                isNumber = int.TryParse(text, out int number) && (number > 0);

                if (isNumber)
                {
                    return number;
                }
                else
                {
                    Console.WriteLine($"'{text}' is not a number, try again ({maxAttempts - attemptsCount} attempts remaining) ...");
                }

                attemptsCount++;

                if (attemptsCount > maxAttempts)
                {
                    Console.WriteLine($"Max attempts count exceeded, asuming {defaultValue} as default value ...");
                    return defaultValue;
                }
            }

            return defaultValue;
        }

        public static void PrintArray(string arrayName, int[] array)
        {
            string arrayElements = string.Join(", ", array ?? new int[] { });

            Console.WriteLine($"{arrayName} = [{arrayElements}]");
        }
    }
}
