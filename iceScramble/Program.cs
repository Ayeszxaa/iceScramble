//JIMENEZ, BLESSIE MAE AYESSA D.

using System;

class IceScramble
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Ice Scramble Land System!");

        // Display flavor options
        Console.WriteLine("Available Flavor:");
        Console.WriteLine("1. Ube");
        Console.WriteLine("2. Strawberry");

        string flavor = GetValidFlavorSelection();

        // Display syrup options
        Console.WriteLine("\nAvailable Syrup:");
        Console.WriteLine("1. Chocolate");
        Console.WriteLine("2. Milk");

        string syrup = GetValidSyrupSelection();

        // Display toppings options
        Console.WriteLine("\nAvailable Toppings:");
        Console.WriteLine("1. Sprinkles");
        Console.WriteLine("2. Marshmallow");

        string toppings = GetValidToppingsSelection();

        // Display the order summary
        Console.WriteLine("\nYour order is:");
        Console.WriteLine($" {flavor} Flavor");
        Console.WriteLine($" with {syrup} Syrup");
        Console.WriteLine($" and {toppings} Toppings ");

        // Wait for user input before closing the program
        Console.WriteLine("\nThankyou for Ordering have a nice day ^_^");
  
          Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    static string GetValidFlavorSelection()
    {
        string flavorInput;
        string flavor;
        bool validSelection = false;

        do
        {
            Console.WriteLine("Please enter the number for your desired flavor:");
            flavorInput = Console.ReadLine();
            switch (flavorInput)
            {
                case "1":
                    flavor = "Ube";
                    validSelection = true;
                    break;
                case "2":
                    flavor = "Strawberry";
                    validSelection = true;
                    break;
                default:
                    Console.WriteLine("Invalid flavor selection! Please try again.");
                    flavor = "";
                    break;
            }
        } while (!validSelection);

        return flavor;
    }

    static string GetValidSyrupSelection()
    {
        string syrupInput;
        string syrup;
        bool validSelection = false;

        do
        {
            Console.WriteLine("Please enter the number for your desired syrup:");
            syrupInput = Console.ReadLine();
            switch (syrupInput)
            {
                case "1":
                    syrup = "Chocolate";
                    validSelection = true;
                    break;
                case "2":
                    syrup = "Milk";
                    validSelection = true;
                    break;
                default:
                    Console.WriteLine("Invalid syrup selection! Please try again.");
                    syrup = "";
                    break;
            }
        } while (!validSelection);

        return syrup;
    }

    static string GetValidToppingsSelection()
    {
        string toppingsInput;
        string toppings;
        bool validSelection = false;

        do
        {
            Console.WriteLine("Please enter the number for your desired toppings:");
            toppingsInput = Console.ReadLine();
            switch (toppingsInput)
            {
                case "1":
                    toppings = "Sprinkles";
                    validSelection = true;
                    break;
                case "2":
                    toppings = "Marshmallow";
                    validSelection = true;
                    break;
                default:
                    Console.WriteLine("Invalid toppings selection! Please try again.");
                    toppings = "";
                    break;
            }
        } while (!validSelection);

        return toppings;
    }
}
