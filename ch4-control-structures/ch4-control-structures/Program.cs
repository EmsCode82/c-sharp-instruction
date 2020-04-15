using System;

namespace ch4_control_structures {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Control Structures App!");

            // command menu example
            string command = "";
            Console.WriteLine("COMMAND MENU:");
            Console.WriteLine("list MENU:");
            Console.WriteLine("add MENU:");
            Console.WriteLine("exit MENU:");
            while (!command.Contains("exit")) {
                Console.WriteLine("Enter a command: ");
                command = Console.ReadLine();
                switch (command) {
                    case "List":
                    case "LIST":
                    case "list":
                        Console.WriteLine("list selected");
                        break;
                    case "add":
                        Console.WriteLine("add selected");
                        break;
                    case "exit":
                        Console.WriteLine("exit selected");
                        break;
                    default:
                        Console.WriteLine("invalid option");
                        break;
                }

            }


            string[] names = { "Sarah", "Sam", "Tyler", "Jacob" };
            // in java: for (Type t: collection)
            foreach (string name in names) {
                Console.WriteLine(name);
            }
            Console.WriteLine("for loop");
            for (int i = 0; i < names.Length; i++) { }
            Console.WriteLine(names[i]);
            
                       
            Console.WriteLine("Bye: ");
        }
    }
}
