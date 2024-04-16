using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExerciciosSequencial
{
    public class Exercicio08
    {
        public void Salario()
        {
            Console.WriteLine("Digite quanto você ganha por hora: ");
            double salarioHora = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite quantas horas você trabalhou esse mês: ");
            double horasTrabalhadas = Convert.ToDouble(Console.ReadLine());

            var salarioTotal = salarioHora * horasTrabalhadas;

            Console.WriteLine("O seu salario desse mês: " + salarioTotal.ToString("C"));
        }
    }
}
