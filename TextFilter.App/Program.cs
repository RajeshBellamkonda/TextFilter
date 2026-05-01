using TextFilter.Core;

namespace TextFilter.App;

internal class Program
{
    static void Main(string[] args)
    {
        var filePath = args.Length > 0 ? args[0] : "input.txt";

        if (!File.Exists(filePath))
        {
            Console.Error.WriteLine($"File not found: {filePath}");
            return;
        }

        var text = File.ReadAllText(filePath);

        var processor = new TextFilterProcessor([
            new MiddleVowelFilter(),
            new ShortWordFilter(3),
            new ContainsLetterFilter('t')
        ]);

        var result = processor.Apply(text);
        Console.WriteLine(result);
    }
}
