namespace TextStats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Analysis analysis = new Analysis(text);
            analysis.CountChars();
            
            foreach (var pair in analysis.Counters)
            {
                Console.WriteLine($"Character: {pair.Key}, Count: {pair.Value}");
            }
        }
    }
}