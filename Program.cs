namespace FinalTask13_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = File.ReadAllText("C:/Users/Jetlove/Downloads/Text1 (1).txt");

            var noPunctuationText = new string(path.Where(c  => !char.IsPunctuation(c)).ToArray()); 

            List<string> Text1 = path.ToLower().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            var query = Text1.GroupBy(x => x)
                .Where(g => g.Count() > 1400)
                .Select(y => new { Слово = y.Key, Количество = y.Count() })
                .ToList();

            foreach (var item in query) 
            { 
                Console.WriteLine(item);
            }
            
        }
    }
}