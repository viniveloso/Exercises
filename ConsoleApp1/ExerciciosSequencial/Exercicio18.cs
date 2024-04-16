using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExerciciosSequencial
{
    public class Exercicio18
    {
        public void Download()
        {
            Console.WriteLine("Digite o tamanho do arquivo (Em MB) que você gostaria de baixar:");
            var arquivo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a velocidade da sua internet (Em Mbps): ");
            var internet = Convert.ToDouble(Console.ReadLine());

            var tempoDeDownload = arquivo * 8 / internet;

            Console.WriteLine("O tempo de download será de " + TimeSpan.FromSeconds(tempoDeDownload));
        }
    }
}
