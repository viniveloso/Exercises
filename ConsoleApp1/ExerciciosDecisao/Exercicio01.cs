using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExerciciosDecisao
{
    public class Exercicio01
    {
        public void NumeroMaior()
        {
            Console.WriteLine("Digite um numero: ");
            var possivelNumero1 = Console.ReadLine();
             
            Console.WriteLine("Digite outro numero: ");
            var possivelNumero2 = Console.ReadLine();

            if (int.TryParse(possivelNumero1, out int numero1) && int.TryParse(possivelNumero2, out int numero2))
            {
                if (numero1 > numero2)
                {
                    Console.WriteLine("O numero maior é: " + numero1);
                }
                else
                {
                    Console.WriteLine("O numero maior é: " + numero2);
                }
            }
            else
            {
                Console.WriteLine("Você não digitou um numero");
            }
            
        }
    }
}
