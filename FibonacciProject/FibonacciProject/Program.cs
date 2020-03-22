using System;
//using FibonacciLibrary;
using FibonacciProject.Library;

namespace FibonacciProject
{
    class Program
    {
        static void Main(string[] args)
        {
            VectorFibonacci();
        }

        private static void VectorFibonacci()
        {
            int n = For_Console.ReadNumber("Elementul \"N\" (final) sir Fibonacci : ", 3, 0);
            int[] Fibonacci_array = Fibonacci_Class.Fibonacci(n, "Fibonacci_Array");
            For_Console.PrintArray("Fibonacci_array", Fibonacci_array);
        }
    }

    
}
