using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Exercicio15
    {
        public void Salario()
        {
            Console.WriteLine("Digite o valor do seu salario por hora: ");
            var salarioHora = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o quantas horas você trabalhou esse mês: ");
            var horasTrabalhadas = Convert.ToDouble(Console.ReadLine());


            double salarioBruto = salarioHora * horasTrabalhadas;
            double inss = salarioBruto * 0.14;
            double sindicato = salarioBruto * 0.5;
            double liquido = salarioBruto - inss - sindicato;
            

            Console.WriteLine("O seu salario bruto é: " + salarioBruto);
            Console.WriteLine("");
            Console.WriteLine("Pagou ao INSS: " + inss);
            Console.WriteLine("");
            Console.WriteLine("Pagou ao sindicato: "+sindicato);
            Console.WriteLine("");
            Console.WriteLine("Salario liquido: "+liquido);


        }
    }
}
