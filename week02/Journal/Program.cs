using System;
using System.Transactions;
using System.IO;
class Program
{
    // Shows creativity and exceeds core requirements:
    // Think of other problems that keep people from writing in their journal and address one of those.
    // Some people think that there is nothing to write or record in a Journal. But I know that we can give
    // this powerfull message of Motivation that says.“Have I seen the hand of God reaching out to touch us or our children or our family today?”
    // And for this reason,there are always things to record in our Journal.
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();

        Console.WriteLine("Welcome to the journal program");

        int enter = 0;
        while (enter == 0)
        {
            Console.WriteLine("Please Select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Message of Motivation");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();
            int chose = int.Parse(choice);

            if (chose == 1)
            {
                Random rnd = new Random();
                int index = rnd.Next(7);
                PromptGenerator prompt = new PromptGenerator();
                prompt.GetRamdomPrompt();
                string ramdom = prompt._prompt[index];
                Console.WriteLine(ramdom);

                string text = Console.ReadLine();
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                Entry newEntry = new Entry();
                newEntry._date = dateText;
                newEntry._entryText = text;
                newEntry._promptText = ramdom;

                theJournal.AddEntry(newEntry);
            }
            else if (chose == 2)
            {
                theJournal.DisplayAll();
            }
            else if (chose == 3)
            {
                Console.WriteLine("What is the file name? ");
                string file = Console.ReadLine();
                theJournal.LoadFromFile(file);
            }
            else if (chose == 4)
            {
                Console.WriteLine("What is the file name? ");
                string file = Console.ReadLine();
                theJournal.SaveToFile(file);
            }
            else if (chose == 5)
            {
                Console.WriteLine("“Have I seen the hand of God reaching out to touch us or our children or our family today?”(President Henry B. Eyring,)");
            }
            else
            {
                enter = 1;
            }

        }
    }
}