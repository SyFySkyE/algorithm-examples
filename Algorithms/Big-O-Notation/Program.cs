using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_O_Notation
{
    class Program
    {
        private static int steps;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                steps = 0;

                Console.WriteLine("Big O Notation\n\n");
                Console.WriteLine("Press 1 for the Constant Time example, 2 for Linear Time and 3 for Quadratic Time");
                Console.WriteLine("As each algorithm runs, a counter will keep track of how many steps it takes for each one. \nEach algorithm will receive an input of 10.");
                Console.WriteLine("When the method is finished, I'll display how many steps it took.");                

                switch (Console.ReadLine())
                {
                    case "1":
                        ConstantTime(10); 
                        break;
                    case "2":
                        LinearTime(10);
                        break;
                    case "3":
                        QuadraticTime(10);
                        break;
                    default:                        
                        break;
                }

                Console.WriteLine($"This one took {steps} steps! \nThink how the number of steps relate to the amount of time and/or memory it took, and how different it would be given a large input size!");

                Console.ReadLine();
            }
        }

        private static void ConstantTime(int index)
        {
            Console.WriteLine($"My favorite number is {index}");
            steps++;

            // No matter how big the input is, whether it's 1 or 1,000,000 the number of steps will always be the same. The size of the input does not change the length of time or the memory it takes to run this method. The time and memory it will take is constant, or O(1).
        }

        private static void LinearTime(int iterations)
        {
            for (int i = 0; i < iterations; i++)
            {
                Console.WriteLine(i);
                steps++;
            }

            // In this example, the input size does effect the length of time it will take to run. In fact, it scales linearly depending on what the input is. If the input is 1, it will run one time. If it is 1,000,000 it will run a million times. Since the runtime depends on the size of the input, or n, therefore, the runtime is O(n).
        }

        private static void QuadraticTime(int size)
        {
            int columns, rows;

            for (columns = 0; columns < size; columns++)
            {
                for (rows = 0; rows < size; rows++)
                {
                    Console.Write($"X: {columns} Y: {rows}  ");

                    steps++;
                }

                Console.WriteLine();

                // In this example, the input size does effects the runtime greatly. Since the size of the input is run in a nested for loop, the runtime will rise exponentially, or O(n^2).
            }
        }
    }
}
