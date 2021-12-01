using System;

namespace TratamentoText
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var resultado = Maisculo("Desenvolvimento de Sistemas - ams");

          
           Console.WriteLine (resultado);
            
        }

      

        public static string Maisculo(string str)
        {
            return str.Length < 4 ? str.ToUpper() : str.Remove(str.Length  -3 ) + str.Substring(str.Length - 3) .ToUpper();
        }

    }

}
