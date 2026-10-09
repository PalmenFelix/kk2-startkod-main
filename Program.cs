ShoppingList list = new ShoppingList("items.txt");
list.Load();

while (true)
{
    Console.WriteLine();
    list.Print();
    Console.WriteLine();
    Console.WriteLine("1. Lägg till vara");
    Console.WriteLine("2. Ta bort vara");
    Console.WriteLine("3. Spara");
    Console.WriteLine("4. Sök vara");
    Console.WriteLine("5. Avsluta");
    Console.Write("Välj: ");

    int choice;

    if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
    {
        Console.WriteLine("Det var inte ett giltigt val.");
        continue;
    }

    if (choice == 1)
    {
        Console.Write("Namn: ");

        string name = Console.ReadLine();

        Console.Write("Pris: ");

        int price;

        if (!int.TryParse(Console.ReadLine(), out price))
        {
            Console.WriteLine("Det var inte ett giltigt pris.");
        }
        else
        {
            try
            {
                Item item = new Item(name, price);
                if (!list.Add(item))
                {
                    Console.WriteLine($"Du har inte råd med varan. Din budget är {list.BudgetRoof} kr");
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Priset får inte vara negativt");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Namnet får inte vara tomt");
            }
        }
    }
    else if (choice == 2)
    {
        Console.Write("Nummer: ");

        int number;

        if (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Ange ett giltigt nummer.");
        }
        else
        {
            list.RemoveAt(number);
        }
    }
    else if (choice == 3)
    {
        list.Save();
    }
    else if (choice == 4)
    {
        Console.Write("Namn att söka efter: ");
        string wanted = Console.ReadLine();
        Item found = list.Find(wanted);

        if (found == null)
        {
            Console.WriteLine("Varan finns inte i listan.");
        }
        else
        {
            Console.WriteLine($"Hittade: {found}");
        }
    }
    else if (choice == 5)
    {
        break;
    }
}
