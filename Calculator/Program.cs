using System;
using System.Runtime.InteropServices.Marshalling;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
           Menu();
        }

        static void Menu()
        {
          Console.Clear();
          Console.WriteLine("O que deseja?");
          Console.WriteLine("1 - Soma");
          Console.WriteLine("2 - Subtração");
          Console.WriteLine("3 - Divisão");
          Console.WriteLine("4 - Multiplicação");
          Console.WriteLine("5 - Sair");

          Console.WriteLine("-----------------");
          Console.WriteLine("Selecione uma opção: ");
          Console.WriteLine("");
          short res = short.Parse(Console.ReadLine());

          switch(res)
          {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Divisao(); break;
            case 4: Multiplicacao(); break;
            case 5: Agradecimento(); System.Environment.Exit(0); break;
            default: Menu(); break;
          }
        }

        static void Soma() 
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            Console.WriteLine("");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Segundo valor: ");
            Console.WriteLine("");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;
            Console.WriteLine($"O resultado da soma é:  {resultado}");
            Console.WriteLine("");
            Console.WriteLine("--Aperte enter para voltar ao Menu");
            Console.ReadLine();
            Menu();
        }  
    
        static void Subtracao()
          {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            Console.WriteLine("");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Segundo valor:");
            Console.WriteLine("");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é {resultado}");
            Console.WriteLine("");
            Console.WriteLine("--Aperte enter para voltar ao Menu");
            Console.ReadLine();
            Menu();
          }
    
        static void Divisao()
        {
          Console.Clear();
          Console.WriteLine("Primeiro valor:");
          Console.WriteLine("");
          float v1 = float.Parse(Console.ReadLine());

          Console.WriteLine("");

          Console.WriteLine("Segundo valor:");
          Console.WriteLine("");
          float v2 = float.Parse(Console.ReadLine());

          Console.WriteLine("");

          float resultado = v1/v2;
          Console.WriteLine($"O resultado da divisão é {resultado}");
          Console.WriteLine("");
            Console.WriteLine("--Aperte enter para voltar ao Menu");
          Console.ReadLine();
          Menu();
        }
    
        static void Multiplicacao()
        {
          Console.Clear();
          Console.WriteLine("Primeiro numero:");
          Console.WriteLine("");
          float v1 = float.Parse(Console.ReadLine());

          Console.WriteLine("");

          Console.WriteLine("Segundo numero:");
          Console.WriteLine("");
          float v2 = float.Parse(Console.ReadLine());

          Console.WriteLine("");

          float resultado = v1 * v2;
          Console.WriteLine($"O resultado da multiplicação é {resultado}");
          Console.WriteLine("");
            Console.WriteLine("--Aperte enter para voltar ao Menu");
          Console.ReadLine();
          Menu();
        }
    
        static void Agradecimento()
        {
          Console.Clear();
          Console.WriteLine("");

          Console.WriteLine("Obrigado por usar o sistema!");
          Console.ReadLine();
        }
    }
}