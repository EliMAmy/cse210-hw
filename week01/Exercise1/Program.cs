using System;

class Program
{
    static void Main(string[] args)
    {
        // ASk the user for their name and last name
        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine();
        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();

        Console.WriteLine($"\nYour name is {last_name}, {first_name} {last_name}.");
        

    }
}


