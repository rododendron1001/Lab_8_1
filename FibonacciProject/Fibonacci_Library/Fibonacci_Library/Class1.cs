using System;

namespace Fibonacci_Library
{
    public class Fibonacci_Class
    {
        public static int[] Fibonacci(int number, string arrayName)
        {
            int[] array1 = new int[number];
            array1[0] = 0;
            array1[1] = 1;
            for (int i = 2; i < number; i++)
            {
                array1[i] = array1[i - 2] + array1[i - 1];
            }
            return array1;
        }
    }
}
