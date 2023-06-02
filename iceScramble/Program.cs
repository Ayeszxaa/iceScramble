using System;

class IceScramble
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Ice Scramble Land System!");

        // Display available flavor with prices
        Console.WriteLine("Available Flavor:");
        Console.WriteLine("1. Ube (₱20)");
        Console.WriteLine("2. Strawberry (₱25)");

        string flavor = GetValidFlavorSelection();

        // Display available syrup with prices
        Console.WriteLine("\nAvailable Syrup:");
        Console.WriteLine("1. Chocolate (₱10)");
        Console.WriteLine("2. Milk (₱5)");

        string syrup = GetValidSyrupSelection();

        // Display available toppings with prices
        Console.WriteLine("\nAvailable Toppings:");
        Console.WriteLine("1. Sprinkles (₱5)");
        Console.WriteLine("2. Marshmallow (₱8)");

        string toppings = GetValidToppingsSelection();

        // Calculate the total price
        int total = GetTotalPrice(flavor, syrup, toppings);

        // Display the order summary
        Console.WriteLine("\nYour order is:");
        Console.WriteLine($"- {flavor} Flavor");
        Console.WriteLine($"- {syrup} Syrup");
        Console.WriteLine($"- {toppings} Toppings");
        Console.WriteLine($"Total Price: ₱{total}");

        // Wait for user input before closing the program
        Console.WriteLine("\nThank you for ordering! Have a nice day ^_^");
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

    static int GetTotalPrice(string flavor, string syrup, string toppings)
    {
        int flavorPrice = GetFlavorPrice(flavor);
        int syrupPrice = GetSyrupPrice(syrup);
        int toppingsPrice = GetToppingsPrice(toppings);

        return flavorPrice + syrupPrice + toppingsPrice;
    }

    static int GetFlavorPrice(string flavor)
    {
        switch (flavor)
        {
            case "Ube":
                return 20;
            case "Strawberry":
                return 25;
            default:
                return 0;
        }
    }

    static int GetSyrupPrice(string syrup)
    {
        switch (syrup)
        {
            case "Chocolate":
                return 10;
            case "Milk":
                return 5;
            default:
                return 0;
        }
    }

    static int GetToppingsPrice(string toppings)
    {
        switch (toppings)
        {
            case "Sprinkles":
                return 5;
            case "Marshmallow":
                return 8;
            default:
                return 0;
        }
    }
}

