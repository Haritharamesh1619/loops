using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            Console.WriteLine("Using 'for' loop:");
            ForLoop(numbers);

            Console.WriteLine("\nUsing 'while' loop:");
            WhileLoop(numbers);

            Console.WriteLine("\nUsing 'do-while' loop:");
            DoWhileLoop(numbers);

            Console.WriteLine("\nUsing 'foreach' loop:");
            ForeachLoop(numbers);

            // Keep the console window open
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }

        static void ForLoop(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine($"Number: {numbers[i]}");
            }
        }

        static void WhileLoop(List<int> numbers)
        {
            int i = 0;
            while (i < numbers.Count)
            {
                Console.WriteLine($"Number: {numbers[i]}");
                i++;
            }
        }

        static void DoWhileLoop(List<int> numbers)
        {
            int i = 0;
            do
            {
                Console.WriteLine($"Number: {numbers[i]}");
                i++;
            } while (i < numbers.Count);
        }

        static void ForeachLoop(List<int> numbers)
        {
            foreach (var number in numbers)
            {
                Console.WriteLine($"Number: {number}");
            }
        }
    }
}
