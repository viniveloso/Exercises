using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Exercicio16
    {
        const double ValorTinta = 80.0;
        public void Tintas()
        {
            Console.WriteLine("Quantos metros quadrados ira pintar: ");
            var metros = Convert.ToDouble(Console.ReadLine());

            double quantidade = metros / (3 * 18);

            var totalLatas = Math.Ceiling(quantidade);

            var total = ValorTinta * totalLatas;

            Console.WriteLine("O valor é: " + total);
            Console.WriteLine("A quantidade de tinta é: "+ totalLatas);
        }
    }
}
