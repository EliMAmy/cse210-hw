using System;

class Program
{
    static void Main(string[] args)
    {
        //We have this products
        Product product1 = new Product("Notebook", "P001", 3.5, 5);
        Product product2 = new Product("Pen", "P002", 1.2, 10);
        Product product3 = new Product("Book", "P098", 5.2, 6);

        //  We Create an address
        Address address = new Address("16 Grassy Plains Blvd", "Springfield", "IL", "USA");

        //  We Create an customer
        Customer customer = new Customer("Daniel Escobedo", address);


        //  We Create an Order
        Order newOrder = new Order();
        newOrder.SetCustomer(customer);
        newOrder.SetList(product1);
        newOrder.SetList(product2);
        newOrder.SetList(product3);


        // Print packing and shipping labels and total cost
        Console.WriteLine("The Total Cost is ($):\n");
        Console.WriteLine(newOrder.TotalCost());
        Console.WriteLine("\nThe Packing label is:");
        newOrder.DisplayPackingLabel();
        Console.WriteLine("\nThe Shipping label is:");
        newOrder.DisplayShippingLabel();

    }
}