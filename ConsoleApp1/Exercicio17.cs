using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Exercicio17
    {
        const double ValorLata = 80.0;
        const double ValorGalao = 25.0;
        public void Tintas()
        {
            Console.WriteLine("Quantos metros quadrados ira pintar: ");
            var metros = Convert.ToDouble(Console.ReadLine());

            double quantidadeLata = metros / (6 * 18);
            double quantidadeMisturada = (metros * 1.10 % (6 * 18)) / (6 * 3.6);
            double quantidadeGalao = metros / (6 * 3.6);

            var lataMisturada = Math.Floor(quantidadeLata);
            var galaoMisturado = Math.Ceiling(quantidadeMisturada);
            var apenasLatas = Math.Ceiling(quantidadeLata);
            var apenasGaloes = Math.Ceiling(quantidadeGalao);

            double valorApenasLatas = ValorLata * apenasLatas;
            double valorApenasGaloes = ValorGalao * apenasGaloes;
            double valorMisturado = (lataMisturada * ValorLata) + (galaoMisturado * ValorGalao);

            Console.WriteLine("Comprar apenas latas de 18 litros: " + apenasLatas);
            Console.WriteLine("Valor total: " + valorApenasLatas.ToString("C"));
            Console.WriteLine("Comprar apenas galões de 3,6 litros: " + apenasGaloes);
            Console.WriteLine("Valor total: " + valorApenasGaloes.ToString("C"));
            Console.WriteLine("Caso você compre misturado você precisara dessa quantidade de latas: " + lataMisturada + " e essa quantidade de galoes: " + galaoMisturado);
            Console.WriteLine("Valor total: " + valorMisturado.ToString("C"));




        }
    }
}
