using System;

namespace csharpStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "Esse texto é um teste";
            Console.WriteLine(text.IndexOf("é"));
            Console.WriteLine(text.ToLower());
            Console.WriteLine(text.ToUpper());
            Console.WriteLine(text.Insert(11, "aqui "));
            Console.WriteLine(text.Remove(5, 5));
            Console.WriteLine(text.Length);




        }
    }
}
