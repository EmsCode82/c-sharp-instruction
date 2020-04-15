using System;

namespace ch4_prj4_common_divisor_app {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Greatest Common Divisor Finder");
            Console.WriteLine();
            // Continue until choice isn't equal to "y" or "Y"
            string choice = "y";
            while (choice.Equals("y")) {
                Console.WriteLine("Enter first number: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number: ");
                int y = Convert.ToInt32(Console.ReadLine());
                int divisor = 0;
                // continue until x = 0
                while (x!=0) {
                    // subtract x from y until y < x
                    while (y>=x) {
                        y -= x;
                    }

                    // swap the values of x and y
                    divisor = x;
                    x = y;
                    y = divisor;
                }

                // display result
                Console.WriteLine("Greatest common divisor: " + divisor);
                Console.WriteLine();

                // see if the user wants to continue
                Console.WriteLine("Continue? (y/n): ");
                choice = Console.ReadLine();
                Console.WriteLine();

            }
        }
    }
}
