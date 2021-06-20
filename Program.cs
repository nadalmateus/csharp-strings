using System;
using Microsoft.VisualBasic;

namespace csharpStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "Esse texto é um teste";
            Console.WriteLine(text.Replace("x", "X"));


            var divisisao = text.Split(" ");
            Console.WriteLine(divisisao[0]);
        }
    }
}
