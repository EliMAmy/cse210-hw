using System;

class Program
{

    static void Main(string[] args)
    {
        DisplayMessage();

        string userName = UserName();
        int userNumber = UserNumber();

        int squaredNumber = Square(userNumber);

        make(squaredNumber, userName);
    }
    //Displays the message, "Welcome to the Program!"
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    //Asks for and returns the user's name 
    static string UserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
    //Asks for and returns the user's favorite number
    static int UserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string number = Console.ReadLine();
        int userNumber = int.Parse(number);
        return userNumber;
    }
    //Accepts an integer as a parameter and returns that number squared
    static int Square(int userNumber)
    {
        int square = userNumber * userNumber;
        return square;
    }
    //Accepts the user's name and the squared number and displays them.
    static void make(int square, string userName)
    {
        Console.Write($"{userName}, the square of your number is {square}");
    }
}