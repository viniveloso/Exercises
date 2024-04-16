using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExerciciosSequencial
{
    public class Exercicio05
    {
        public void MetrosParaCentimetros()
        {
            Console.WriteLine("Digite o número de metros que você gostaria de converter para centimetros: ");
            var metros = Convert.ToInt32(Console.ReadLine());
            var conversao = metros * 100;
            Console.WriteLine(metros + " metros fica " + conversao + " centimetros");
        }
    }
}
