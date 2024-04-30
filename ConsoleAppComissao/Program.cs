using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppComissao
{
    internal class Program
    {
        static void Main(string[] args)
        {
               
                const int numeroDeVendedores = 5;
                string[] nomes = new string[numeroDeVendedores];
                decimal[] vendas = new decimal[numeroDeVendedores];
                decimal[] comissoes = new decimal[numeroDeVendedores];

            
                for (int i = 0; i < numeroDeVendedores; i++)
                {
                    Console.WriteLine($"Digite o nome do vendedor {i + 1}:");
                    nomes[i] = Console.ReadLine();

                    Console.WriteLine($"Digite o total de vendas de {nomes[i]}:");
                    vendas[i] = decimal.Parse(Console.ReadLine());

                   
                    if (vendas[i] <= 20000)
                    {
                        comissoes[i] = vendas[i] * 0.05m;
                    }
                    else if (vendas[i] <= 40000)
                    {
                        comissoes[i] = vendas[i] * 0.06m; 
                    }
                    else
                    {
                        comissoes[i] = vendas[i] * 0.07m; 
                    }
                }

                
                Console.WriteLine("\nResultados das Vendas:");
                for (int i = 0; i < numeroDeVendedores; i++)
                {
                    Console.WriteLine($"{nomes[i]} - Total de Vendas: R${vendas[i]:N2}, Comissão: R${comissoes[i]:N2}");
                }

                Console.WriteLine("\nPressione qualquer tecla para encerrar...");
                Console.ReadKey();
            }
        }
    }
    

