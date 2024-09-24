using TDEMARCOS;

Inventory inventory = new Inventory();
int option;

do
{
    Console.WriteLine("Inventory Management System");
    Console.WriteLine("1. Add Item");
    Console.WriteLine("2. List Items");
    Console.WriteLine("3. Edit Item");
    Console.WriteLine("4. Remove Item");
    Console.WriteLine("5. Exit");
    Console.Write("Choose an option: ");
    option = int.Parse(Console.ReadLine());

    switch (option)
    {
        case 1:
            AddItem(inventory);
            break;
        case 2:
            inventory.ListItems();
            break;
        case 3:
            EditItem(inventory);
            break;
        case 4:
            RemoveItem(inventory);
            break;
        case 5:
            Console.WriteLine("Exiting the system...");
            break;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
} while (option != 5);

static void AddItem(Inventory inventory)
{
    Console.Write("Item name: ");
    string name = Console.ReadLine();

    Console.Write("Quantity: ");
    int quantity = int.Parse(Console.ReadLine());

    Console.Write("Price: ");
    decimal price = decimal.Parse(Console.ReadLine());

    Item item = new Item(name, quantity, price);
    inventory.AddItem(item);
}

static void EditItem(Inventory inventory)
{
    inventory.ListItems();

    Console.Write("Enter the item number you wish to edit: ");
    int index = int.Parse(Console.ReadLine()) - 1;

    Console.Write("New item name: ");
    string name = Console.ReadLine();

    Console.Write("New quantity: ");
    int quantity = int.Parse(Console.ReadLine());

    Console.Write("New price: ");
    decimal price = decimal.Parse(Console.ReadLine());

    Item newItem = new Item(name, quantity, price);
    inventory.EditItem(index, newItem);
}

static void RemoveItem(Inventory inventory)
{
    inventory.ListItems();

    Console.Write("Enter the item number you wish to remove: ");
    int index = int.Parse(Console.ReadLine()) - 1;

    inventory.RemoveItem(index);
}
