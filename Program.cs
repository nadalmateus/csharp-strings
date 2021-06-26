using System;
using System.Text;

namespace csharpStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            var text = new StringBuilder();
            text.Append("Esse texto é um teste");
            text.Append("Esse texto é um teste 1");
            text.Append("Esse texto é um teste 2");


            text.ToString();


            Console.WriteLine(text);

        }
    }
}
