using System;

class Program
{
    static void Main(string[] args)
    {
        var scriptureLibrary = new ScriptureLibrary();
        
        var scripture = scriptureLibrary.GetRandomScripture();

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture);
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");

            var input = Console.ReadLine();
            if (input?.ToLower() == "quit") break;

            scripture.HideRandomWords(3);

            if (scripture.AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture);
                Console.WriteLine("All words are hidden. Goodbye!");
                break;
            }
        }
    }
}
