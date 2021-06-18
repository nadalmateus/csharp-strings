using System;

namespace csharpStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "Esse texto é um teste";
            Console.WriteLine(text.IndexOf("é"));
            Console.WriteLine(text.LastIndexOf("s"));

        }
    }
}
