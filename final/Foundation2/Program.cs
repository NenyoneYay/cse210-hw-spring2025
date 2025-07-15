using System;

class Program
{
    // static string MainMenu()
    // {
    //     private int _userChoice;
    //     Console.WriteLine("Select an option: ");
    //     /*
    //         Choices:
    //         1. Add new Customer
    //         2. Select Customer
    //         3. Add product to order
    //         4. View contents of order
    //         5. Print packing label
    //         6. Print shipping label
    //         7. Exit
    //     */
    //     _userChoice = Console.ReadLine();
    //     return _userChoice;
    // }
    static void Main(string[] args)
    {
        //Declare customers
        Customer bruceWayne = new Customer("Bruce Wayne");
        Customer Kuzco = new Customer("Emperor Kuzco");
        Customer Aang = new Customer("Avatar Aang");

        //Declare addresses
        Address address1 = new Address("1007 Mountain Drive", "Gotham", "New Jersey", "United States of America");
        Address address2 = new Address("1 Llama Lane", "Kuzcotopia", "High Andes", "Peru");
        Address address3 = new Address("112 Air Temple Way", "Southern Air Temple", "Air Nation", "China");

        //Testing the address info getter
        Console.WriteLine(address1.GetAddressInfo());
        Console.WriteLine(address2.GetAddressInfo());
        Console.WriteLine(address3.GetAddressInfo());
        Console.WriteLine();

        //Set addresses to customers
        bruceWayne.SetAddress(address1);
        Kuzco.SetAddress(address2);
        Aang.SetAddress(address3);

        //Testing the address international checker
        Console.WriteLine("Bruce Wayne: Is international? " + bruceWayne.IsInternational(address1));
        Console.WriteLine("Emperor Kuzco: Is international? " + Kuzco.IsInternational(address2));
        Console.WriteLine("Avatar Aang: Is international? " + Aang.IsInternational(address3));
        Console.WriteLine();

        //Declare products
        Product granola = new Product("Granola Bars", 528693, 3.99);
        Product beans = new Product("Nen's Refried Beans", 325876, 2.99);
        Product television = new Product("Television", 339864, 399.99);

        //Declare orders
        Order order1 = new Order();
        Order order2 = new Order();
        Order order3 = new Order();
        //Add products to order 1
        order1.AddProduct(granola, 5);
        order1.AddProduct(beans, 1);
        //Add products to order 2
        order2.AddProduct(television, 10);
        //Add products to order 3
        order3.AddProduct(granola, 6);
        order3.AddProduct(beans, 3);
        order3.AddProduct(television, 1);

        //Set orders to customers
        bruceWayne.SetOrder(order1);
        Kuzco.SetOrder(order2);
        Aang.SetOrder(order3);
        order1.SetCustomer(bruceWayne);
        order2.SetCustomer(Kuzco);
        order3.SetCustomer(Aang);

        //Calculate cost of order
        Console.WriteLine("Price of order 1: " + order1.CalculateCost(bruceWayne.IsInternational(address1)) + "\n(Including Shipping cost: $" + order1.GetShippingCost() + ")");
        Console.WriteLine("Price of order 2: " + order2.CalculateCost(Kuzco.IsInternational(address2)) + "\n(Including Shipping cost: $" + order2.GetShippingCost() + ")");
        Console.WriteLine("Price of order 3: " + order3.CalculateCost(Aang.IsInternational(address3)) + "\n(Including Shipping cost: $" + order3.GetShippingCost() + ")");
        Console.WriteLine();

        //Create packing labels for each order
        order1.PackingLabel();
        order2.PackingLabel();
        order3.PackingLabel();

        //Create shipping labels for each order
        order1.ShippingLabel();
        order2.ShippingLabel();
        order3.ShippingLabel();
    }
}

/* Requirements: 
    Calculate the total cost of an order [X]
    Add a shipping cost [X]
    Alter shipping cost for international [X]
    Print packing label with name and product ID of each product in order [X]
    Print shipping label with name and address of customer[X]
    Method for if customer is in US or not [X]
    Method for returning strings of an address[X]
*/