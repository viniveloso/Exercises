using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1.ExerciciosDecisao
{
    public class Exercicio12
    {
        public void FolhaDePagamento()
        {
            Console.WriteLine("Digite o valor da sua hora trabalhada: ");
            var valorHora = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite quantas horas você trabalhou no mês: ");
            var horaTrabalhada = Convert.ToInt32(Console.ReadLine());

            var salarioBruto = (valorHora * horaTrabalhada);

            //
            var ir05 = salarioBruto * 0.05;
            var inss = salarioBruto * 0.10;
            var fgts = salarioBruto * 0.11;
            var totalDescontos = ir05 + inss;
            var salarioLiquido = salarioBruto - ir05 - inss;
            //
            var ir10 = salarioBruto * 0.10;
            var inss2 = salarioBruto * 0.10;
            var fgts2 = salarioBruto * 0.11;
            var totalDescontos2 = ir10 + inss;
            var salarioLiquido2 = salarioBruto - ir10 - inss;
            //
            var ir20 = salarioBruto * 0.20;
            var inss3 = salarioBruto * 0.10;
            var fgts3 = salarioBruto * 0.11;
            var totalDescontos3 = ir20 + inss;
            var salarioLiquido3 = salarioBruto - ir20 - inss;


            if (salarioBruto < 900)
            {
                Console.WriteLine("Salario bruto: " + salarioBruto.ToString("C"));
                Console.WriteLine("IR: Isento");
                Console.WriteLine("INSS: Isento");
                Console.WriteLine("FGTS: Isento");
                Console.WriteLine("Total de descontos: 0");
                Console.WriteLine("Salario Liquido: " + salarioBruto.ToString("C"));
            }

            if (salarioBruto < 1500 && salarioBruto > 900)
            {
                Console.WriteLine("Salario bruto: " + salarioBruto.ToString("C"));
                Console.WriteLine("IR: " + ir05.ToString("C"));
                Console.WriteLine("INSS: " + inss.ToString("C"));
                Console.WriteLine("FGTS: " + fgts.ToString("C"));
                Console.WriteLine("Total de descontos: " + totalDescontos.ToString("C"));
                Console.WriteLine("Salario Liquido: " + salarioLiquido.ToString("C"));
            }

            if (salarioBruto > 1500 && salarioBruto < 2500)
            {
                Console.WriteLine("Salario bruto: " + salarioBruto.ToString("C"));
                Console.WriteLine("IR: " + ir10.ToString("C"));
                Console.WriteLine("INSS: " + inss2.ToString("C"));
                Console.WriteLine("FGTS: " + fgts2.ToString("C"));
                Console.WriteLine("Total de descontos: " + totalDescontos2.ToString("C"));
                Console.WriteLine("Salario Liquido: " + salarioLiquido2.ToString("C"));
            }

            if (salarioBruto > 2500)
            {
                Console.WriteLine("Salario bruto: " + salarioBruto.ToString("C"));
                Console.WriteLine("IR: " + ir20.ToString("C"));
                Console.WriteLine("INSS: " + inss3.ToString("C"));
                Console.WriteLine("FGTS: " + fgts3.ToString("C"));
                Console.WriteLine("Total de descontos: " + totalDescontos3.ToString("C"));
                Console.WriteLine("Salario Liquido: " + salarioLiquido3.ToString("C"));
            }
        }
    }
}

