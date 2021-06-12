using System;

namespace csharpStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var price = 10.2;
            // var texto = "O preço do produto é " + price;
            // var texto = string.Format("O preço do produto é {0}", price);
            // var texto = $"o preço do produto é {price}";
            var texto = $@"o preço 
            do produto é {price}";

            Console.WriteLine(texto);
        }
    }
}
