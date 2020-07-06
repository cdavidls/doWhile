using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 18;
            bool adicionar = true;

            do
            {
                idade++;
                Console.WriteLine(idade);
            } while (adicionar == false);

            Console.ReadKey();
        }
    }
}
