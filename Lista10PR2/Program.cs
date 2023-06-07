using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista10PR2
{
    internal class Program
    {
        public static void Exercício1()
        {
            float[] vet1;
            float soma = 0, maiorV, menorV, div;

            maiorV = float.MinValue;
            menorV = float.MaxValue;

            Console.WriteLine("Digite o tamanho do vetor: ");
            float n = float.Parse(Console.ReadLine());

            vet1 = new float[(int)n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o valor da posição [{0}]: ", i);
                vet1[i] = int.Parse(Console.ReadLine());
                soma += vet1[i];

                if (vet1[i] > maiorV)
                    maiorV = vet1[i];

                if (vet1[i] < menorV)
                    menorV = vet1[i];
            }
            div = soma / n;
            Console.WriteLine("O maior valor é: " + maiorV);
            Console.WriteLine("O menor valor é: " + menorV);
            Console.WriteLine("A média é: " + div);
        }
        public static void Exercício2()
        {
            float[] vet1;
            float soma = 0, div;

            Console.WriteLine("Digite o tamanho do vetor (Deve ser maior que 0): ");
            float n = float.Parse(Console.ReadLine());

            
                

            vet1 = new float[(int)n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o valor da posição [{0}]: ", i);
                vet1[i] = int.Parse(Console.ReadLine());
                soma += vet1[i];
            }
            div = soma / n;

            for (int i = 0; i < n; i++)
            {
                if (vet1[i] >= div)
                    Console.WriteLine("Põsição[{0}] = {1}", i, vet1[i]);
            }
        }
        public static void Exercício3()
        {
            float[] vet1;
            float soma = 0, div;

            Console.WriteLine("Digite o tamanho do vetor (Deve ser maior que 0): ");
            float n = float.Parse(Console.ReadLine());

            vet1 = new float[(int)n];
            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                vet1[i] = rand.Next(10, 50);
                soma += vet1[i];
            }
            div = soma / n;

            for (int i = 0; i < n; i++)
            {
                if (vet1[i] >= div)
                    Console.WriteLine("Põsição[{0}] = {1}", i, vet1[i]);
            }
        }
        public static void Exercício4()
        {
            

            Console.WriteLine("Digite o tamanho do vetor: ");
            int n = int.Parse(Console.ReadLine());

            string[] assinaturas = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite os nomes: ");
                assinaturas[i] = Console.ReadLine();
            }
            
            Array.Reverse(assinaturas);
            Console.WriteLine("");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(assinaturas[i]);
            }
        }
        public static void Exercício5()
        {
            float[] vet1;
            float somaPar = 0, somaImpar = 0;

            Console.WriteLine("Digite o tamanho do vetor (Deve ser maior que 0): ");
            float n = float.Parse(Console.ReadLine());

            vet1 = new float[(int)n];
            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                vet1[i] = rand.Next(10, 50);

                if (vet1[i] % 2 == 0)
                    somaPar++;
                else
                    somaImpar++;
            }
            Console.WriteLine("Par: " + somaPar);
            Console.WriteLine("Impar: " + somaImpar);
        }

        static void Main(string[] args)
        {
            int op;

            Console.WriteLine("=====MENU=====");
            Console.WriteLine("1- Exercício 1");
            Console.WriteLine("2- Exercício 2");
            Console.WriteLine("3- Exercício 3");
            Console.WriteLine("4- Exercício 4");
            Console.WriteLine("5- Exercício 5");
            Console.WriteLine("Digite o exercício: ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Exercício1();
                    break;
                case 2:
                    Exercício2();
                    break;
                case 3:
                    Exercício3();
                    break;
                case 4:
                    Exercício4();
                        break;
                case 5:
                    Exercício5();
                    break;
                default:
                    Console.WriteLine("Valor inválido!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
