using System;

namespace csharpStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "Esse texto é um teste";
            Console.WriteLine(text.CompareTo("Testando"));
            Console.WriteLine(text.Contains("teste"));
            Console.WriteLine(text.Contains("Teste", StringComparison.OrdinalIgnoreCase));


        }
    }
}
