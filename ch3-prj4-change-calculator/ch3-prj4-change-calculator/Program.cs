using System;

namespace ch3_prj4_change_calculator {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Change Calculator");
            Console.WriteLine();
            Console.WriteLine("Continue (y/n)?");
            string choice = "y";
            while (choice.Equals("y")) {
                Console.WriteLine("Enter number of cents (0-99): ");
                int cents = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                // Calculate number of quarters
                int quarters = cents / 25; // get number of quarters
                cents %= 25;               // assign the remainder to the cents
                // Calculate number of dimes
                int dimes = cents / 10;    // get numver of dimes
                cents %= 10;               // assign the remainder to the cents
                // Calculate number of nickels and pennies
                int nickles = cents / 5;   // get number of nickles
                int pennies = cents % 5;   // get number of pennies

                // Display the results
                Console.WriteLine("Quarters: " + quarters);
                Console.WriteLine("Dimes: " + dimes);
                Console.WriteLine("Nickels: " + nickles);
                Console.WriteLine("Pennies: " + pennies);

                // See if the user wants to continue
                Console.WriteLine("Continue? (y/n): ");
                Console.ReadLine();
                Console.WriteLine();


            }
        }
    }
}
