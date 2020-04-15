using System;

namespace RectangleApp {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Rectangle Calculator!");
            Console.WriteLine("Press y to continue");
            String choice = "y";
            while (choice.Equals("y")) {                
                Console.WriteLine("Enter Length: ");
                double length = Console.Read();
                double width = Console.Read();
                double area = length * width;
                double perimeter = 2 * length + 2 * width;
                Console.WriteLine("Area:        " + area);
                Console.WriteLine("Perimeter:   " + perimeter);
                Console.WriteLine();
                Console.WriteLine("Continue? (y/n): ");
                Console.ReadLine();
                Console.WriteLine();
            }
        }
    }
}
