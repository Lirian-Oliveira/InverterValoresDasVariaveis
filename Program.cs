using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InverterValorDasVariaveis
{
    class Program
    {
      
        
            static void Main(string[] args)
            {
                double A, B;

                Console.Write("Informe um número para A: ");
                A = double.Parse(Console.ReadLine());
                Console.Write("Informe um número para B: ");
                B = double.Parse(Console.ReadLine());

                A += B;
                B = A - B;
                A -= B;
                Console.WriteLine("O novo valor de A é: " + A);
                Console.WriteLine("O novo valor de B é: " + B);

            Console.WriteLine("");
            Console.Read();
        }
        }

    }