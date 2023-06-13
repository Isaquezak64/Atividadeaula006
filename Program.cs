using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividadeaula006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mes;
            string periodo;

            Console.WriteLine("Olá seja Bem-vindo ao ZAK-AIR");
            Console.WriteLine("Qual mês você deseja viajar:\n08-agosto\n09-setembro\n10-Outubro");
            mes = int.Parse(Console.ReadLine());

            int dia;
            if (mes == 08 ||mes == 09 ||mes == 10) {

                Console.WriteLine("Agora escolha o dia da viagem");
                dia = int.Parse(Console.ReadLine());
                if(dia >=6 && dia <= 21)
                {
                    Console.WriteLine("Qual o periodo Sr(a) deseja comprar a passagem:");
                    Console.WriteLine("Manhã:\nTarde:\nNoite:");
                    periodo = (Console.ReadLine());
                    Console.WriteLine("Parabens passagem confirmada");
                    Console.WriteLine($"Mes{mes}");
                    Console.WriteLine($"Dia{dia}");
                    Console.WriteLine($"Periodo {periodo}");
                }
                


            }
            else {

                Console.WriteLine("mes invalido");
                Main(null);
            }
            Console.ReadKey();

        }
    }
}
