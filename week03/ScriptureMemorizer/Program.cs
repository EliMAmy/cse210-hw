using System;

class Program
{
    static void Main(string[] args)
    {
        string theBook = "Proverbs";
        int theChapter = 3;
        int theVerse = 5;
        int theEndVerse = 6;

        Reference newReference = new Reference(theBook,theChapter,theVerse,theEndVerse);
        Scripture newScripture = new Scripture();
        

        string text = "in Trust the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        Console.WriteLine($"{theBook} {theChapter}: {theVerse}-{theEndVerse} {text}");
        List<string> words = text.Split(' ').ToList();
        foreach (string str in words)
        {
            Word nword = new Word();
            nword.SetWord(str);
            newScripture.SetWords(nword);
        }

        int again = 0;
        while (again == 0)
        {
            Console.WriteLine("Press enter to continue or type quit to finish:");
            string answer = Console.ReadLine();

            if (answer != "quit")
            {
                Console.Clear();
                
            }
            else
            {
                again = 1;
            }
        }
        
    }
}