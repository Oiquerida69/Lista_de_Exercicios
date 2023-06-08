using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListadeAtividades
{
    internal class Program
    {
            static void Main()
            {
                Console.Write("Digite o número total de eleitores: ");
                int totalEleitores = int.Parse(Console.ReadLine());

                Console.Write("Digite o número de votos brancos: ");
                int votosBrancos = int.Parse(Console.ReadLine());

                Console.Write("Digite o número de votos nulos: ");
                int votosNulos = int.Parse(Console.ReadLine());

                Console.Write("Digite o número de votos válidos: ");
                int votosValidos = int.Parse(Console.ReadLine());

                double percentualBrancos = (double)votosBrancos / totalEleitores * 100;
                double percentualNulos = (double)votosNulos / totalEleitores * 100;
                double percentualValidos = (double)votosValidos / totalEleitores * 100;

                Console.WriteLine($"Percentual de votos brancos: {percentualBrancos}%");
                Console.WriteLine($"Percentual de votos nulos: {percentualNulos}%");
                Console.WriteLine($"Percentual de votos válidos: {percentualValidos}%");

            Atv02();
            Atv03();
            Atv04();
            Atv05();
            Atv06();
            Atv07();
            Atv08();
            Atv09();
            Atv10();
            Atv11();
            
            }


            static void Atv02()
            {
                Console.Write("Digite o salário mensal atual: ");
                double salarioAtual = double.Parse(Console.ReadLine());

                Console.Write("Digite o percentual de reajuste: ");
                double percentualReajuste = double.Parse(Console.ReadLine());

                double valorReajuste = salarioAtual * (percentualReajuste / 100);
                double novoSalario = salarioAtual + valorReajuste;

                Console.WriteLine($"Novo salário: R${novoSalario}");
            }


           static void Atv03()
            {
                double salarioFixo = 2000.00;
                double comissaoPorCarro = 300.00;
                double percentualVendas = 0.05;

                Console.Write("Digite o número de carros vendidos: ");
                int carrosVendidos = int.Parse(Console.ReadLine());

                Console.Write("Digite o valor total das vendas: ");
                double valorVendas = double.Parse(Console.ReadLine());

                double salarioFinal = salarioFixo + (comissaoPorCarro * carrosVendidos) + (percentualVendas * valorVendas);

                Console.WriteLine($"Salário final do vendedor: R${salarioFinal}");
            }


            static void Atv04()
            {
                Console.Write("Digite a base do retângulo: ");
                double baseRetangulo = double.Parse(Console.ReadLine());

                Console.Write("Digite a altura do retângulo: ");
                double alturaRetangulo = double.Parse(Console.ReadLine());

                double areaRetangulo = baseRetangulo * alturaRetangulo;

                Console.WriteLine($"A área do retângulo é: {areaRetangulo}");
            }


            static void Atv05()
            {
                Console.WriteLine("Digite um valor: ");
                int valor = int.Parse(Console.ReadLine());

                int antecessor = valor - 1;

                Console.WriteLine("O antecessor de {0} é {1}", valor, antecessor);
            }


            static void Atv06()
            {
                Console.WriteLine("Digite a temperatura em graus Fahrenheit: ");
        double fahrenheit = double.Parse(Console.ReadLine());

            double celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine("A temperatura em graus Celsius é: {0}", celsius);
    }

        static void Atv07()
        {
            Console.WriteLine("Digite o número de maçãs compradas: ");
            int quantidade = int.Parse(Console.ReadLine());

            double custoTotal;

            if (quantidade < 12)
            {
                custoTotal = quantidade * 1.30;
            }
            else
            {
                custoTotal = quantidade * 1.00;
            }

            Console.WriteLine("O custo total da compra é: R$ {0}", custoTotal);
        }


        static void Atv08()
        {
            Console.WriteLine("Digite o primeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            int maior;

            if (valor1 > valor2)
            {
                maior = valor1;
            }
            else
            {
                maior = valor2;
            }

            Console.WriteLine("O maior valor é: {0}", maior);
        }


        static void Atv09()
        {
            Console.WriteLine("Digite o primeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            int menor;
            int maior;

            if (valor1 < valor2)
            {
                menor = valor1;
                maior = valor2;
            }
            else
            {
                menor = valor2;
                maior = valor1;
            }

            Console.WriteLine("Os valores em ordem crescente são: {0} e {1}", menor, maior);
        }


        static void Atv10()
        {
            Console.WriteLine("Digite o primeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor: ");
            int valor3 = int.Parse(Console.ReadLine());

            int soma;

            if (valor1 > valor2 && valor1 > valor3)
            {
                soma = valor1 + (valor2 > valor3 ? valor2 : valor3);
            }
            else if (valor2 > valor1 && valor2 > valor3)
            {
                soma = valor2 + (valor1 > valor3 ? valor1 : valor3);
            }
            else
            {
                soma = valor3 + (valor1 > valor2 ? valor1 : valor2);
            }

            Console.WriteLine("A soma dos dois maiores valores é: {0}", soma);
        }



        static void Atv11()
        {
            Console.WriteLine("Digite o primeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor: ");
            int valor3 = int.Parse(Console.ReadLine());

            int menor;
            int meio;
            int maior;

            if (valor1 < valor2 && valor1 < valor3)
            {
                menor = valor1;

                if (valor2 < valor3)
                {
                    meio = valor2;
                    maior = valor3;
                }
                else
                {
                    meio = valor3;
                    maior = valor2;
                }
            }
            else if (valor2 < valor1 && valor2 < valor3)
            {
                menor = valor2;

                if (valor1 < valor3)
                {
                    meio = valor1;
                    maior = valor3;
                }
                else
                {
                    meio = valor3;
                    maior = valor1;
                }
            }
            else
            {
                menor = valor3;

                if (valor1 < valor2)
                {
                    meio = valor1;
                    maior = valor2;
                }
                else
                {
                    meio = valor2;
                    maior = valor1;
                }
            }

            Console.WriteLine("Os valores em ordem crescente são: {0}, {1} e {2}", menor, meio, maior);
        }
    }
}
   
