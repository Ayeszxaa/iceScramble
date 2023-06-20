//JIMENEZ, BLESSIE MAE AYESSA D.
using System;
using System.Collections.Generic;

class IceScramble
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Ice Scramble Land System!");

        // Define available flavors with prices
        List<string> flavors = new List<string> { "Ube (₱20)", "Strawberry (₱25)" };

        // Display available flavors with prices
        Console.WriteLine("Available Flavor:");
        DisplayMenuItems(flavors);

        string flavor = GetValidSelection(flavors);

        // Define available syrups with prices
        List<string> syrups = new List<string> { "Chocolate (₱10)", "Milk (₱5)" };

        // Display available syrups with prices
        Console.WriteLine("\nAvailable Syrup:");
        DisplayMenuItems(syrups);

        string syrup = GetValidSelection(syrups);

        // Define available toppings with prices
        List<string> toppings = new List<string> { "Sprinkles (₱5)", "Marshmallow (₱8)" };

        // Display available toppings with prices
        Console.WriteLine("\nAvailable Toppings:");
        DisplayMenuItems(toppings);

        string selectedToppings = GetValidSelection(toppings);

        // Calculate the total price
        int total = GetTotalPrice(flavors, syrup, toppings);

        // Display the order summary
        Console.WriteLine("\nYour order is:");
        Console.WriteLine($"- {flavor} Flavor");
        Console.WriteLine($"- {syrup} Syrup");
        Console.WriteLine($"- {selectedToppings} Toppings");
        Console.WriteLine($"Total Price: ₱{total}");

        // Wait for user input before closing the program
        Console.WriteLine("\nThank you for ordering! Have a nice day ^_^");
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    static void DisplayMenuItems(List<string> items)
    {
        for (int i = 0; i < items.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {items[i]}");
        }
    }

    static string GetValidSelection(List<string> items)
    {
        string input;
        int selectedIndex;
        bool validSelection = false;

        do
        {
            Console.WriteLine("Please enter the number for your desired selection:");
            input = Console.ReadLine();

            if (int.TryParse(input, out selectedIndex) && selectedIndex >= 1 && selectedIndex <= items.Count)
            {
                validSelection = true;
            }
            else
            {
                Console.WriteLine("Invalid selection! Please try again.");
            }
        } while (!validSelection);

        return items[selectedIndex - 1];
    }

    static int GetTotalPrice(List<string> flavors, string syrup, List<string> toppings)
    {
        int flavorPrice = GetFlavorPrice(flavors);
        int syrupPrice = GetSyrupPrice(syrup);
        int toppingsPrice = GetToppingsPrice(toppings);

        return flavorPrice + syrupPrice + toppingsPrice;
    }

    static int GetFlavorPrice(List<string> flavors)
    {
        string flavor = flavors[0]; // Default to the first flavor
        switch (flavor)
        {
            case "Ube (₱20)":
                return 20;
            case "Strawberry (₱25)":
                return 25;
            default:
                return 0;
        }
    }

    static int GetSyrupPrice(string syrup)
    {
        switch (syrup)
        {
            case "Chocolate (₱10)":
                return 10;
            case "Milk (₱5)":
                return 5;
            default:
                return 0;
        }
    }

    static int GetToppingsPrice(List<string> toppings)
    {
        int totalPrice = 0;
        foreach (string topping in toppings)
        {
            switch (topping)
            {
                case "Sprinkles (₱5)":
                    totalPrice += 5;
                    break;
                case "Marshmallow (₱8)":
                    totalPrice += 8;
                    break;
                default:
                    break;
            }
        }
        return totalPrice;
    }
}
