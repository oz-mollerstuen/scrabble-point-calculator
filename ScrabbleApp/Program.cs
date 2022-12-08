namespace ScrabbleApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please Enter A Word For Me To Score:");
            string? wordInp = Console.ReadLine();
            string[] letters = File.ReadAllLines("./data/input.txt");
            Console.WriteLine("The words score is " + Scrabble.GetScore(wordInp, letters));
            Main();
        }
    }
}