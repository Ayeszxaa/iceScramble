using System;

class IceScramble
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Ice Scramble Land System!");

        string[] flavors = { "Ube", "Strawberry" };
        string[] syrups = { "Chocolate", "Milk" };
        string[] toppings = { "Sprinkles", "Marshmallow" };

        Console.WriteLine("Available Flavor:");
        for (int i = 0; i < flavors.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {flavors[i]} (₱{20 + i * 5})");
        }

        int flavorIndex = GetValidSelection("flavor", flavors.Length);
        string flavor = flavors[flavorIndex - 1];

        Console.WriteLine("\nAvailable Syrup:");
        for (int i = 0; i < syrups.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {syrups[i]} (₱{10 - i * 5})");
        }

        int syrupIndex = GetValidSelection("syrup", syrups.Length);
        string syrup = syrups[syrupIndex - 1];

        Console.WriteLine("\nAvailable Toppings:");
        for (int i = 0; i < toppings.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {toppings[i]} (₱{5 + i * 3})");
        }

        int toppingsIndex = GetValidSelection("toppings", toppings.Length);
        string selectedToppings = toppings[toppingsIndex - 1];

        int total = GetFlavorPrice(flavor) + GetSyrupPrice(syrup) + GetToppingsPrice(selectedToppings);

        Console.WriteLine("\nYour order is:");
        Console.WriteLine($"- {flavor} Flavor");
        Console.WriteLine($"- {syrup} Syrup");
        Console.WriteLine($"- {selectedToppings} Toppings");
        Console.WriteLine($"Total Price: ₱{total}");

        Console.WriteLine("\nThank you for ordering! Have a nice day ^_^");
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    static int GetValidSelection(string item, int length)
    {
        int selectedIndex;
        bool validSelection = false;

        do
        {
            Console.WriteLine($"Please enter the number for your desired {item}:");
            string input = Console.ReadLine();
            validSelection = int.TryParse(input, out selectedIndex) && selectedIndex >= 1 && selectedIndex <= length;

            if (!validSelection)
            {
                Console.WriteLine($"Invalid {item} selection! Please try again.");
            }
        } while (!validSelection);

        return selectedIndex;
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

