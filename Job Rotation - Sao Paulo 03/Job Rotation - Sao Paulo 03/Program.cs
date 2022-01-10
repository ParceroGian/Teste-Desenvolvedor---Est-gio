using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Job_Rotation___Sao_Paulo_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\dados.json");

            var dados = JsonConvert.DeserializeObject<List<Dados>>(json);

            int count = dados.Count;

            double[] vetor = new double[count];

            double soma = 0;
            int m = 0;
            int indiceMaior = 0;
            int indiceMenor = 0;
            double valMaior = double.MinValue;
            double valMenor = double.MaxValue;

            for (int i = 0; i < count; i++)
            {
                if (dados[i].valor != 0)
                {
                    vetor[i] = dados[i].valor;
                    soma = soma + vetor[i];
                    m++;
                    if (dados[i].valor > valMaior )
                    {
                        indiceMaior = i;
                        valMaior = dados[i].valor;
                    }
                }
            }

            for (int i = 0; i < count; i++)
            {
                if (dados[i].valor != 0)
                {
                    if (valMenor > dados[i].valor)
                    {
                        indiceMenor = i;
                        valMenor = dados[i].valor;
                    }
                }
            }

            double media = soma / m;
            m = 0;
            for (int i = 0; i < count; i++)
            {
                if (dados[i].valor > media)
                {
                    m++;
                }
            }
            
            Console.WriteLine($"O menor valor do mês ocorre no dia {indiceMenor + 1} Valor: R$ {vetor[indiceMenor]}");
            Console.WriteLine($"O maior valor do mês ocorre no dia {indiceMaior + 1} Valor: R$ {vetor[indiceMaior]}");
            Console.WriteLine();
            Console.WriteLine($"Média mensal: {media:F4}");
            Console.WriteLine($"{m} dia(s) o faturamento foi superior a media mensal");
            Console.WriteLine();


            for (int i = 0; i < count; i++)
            {
                if (dados[i].valor != 0)
                {
                    if (dados[i].valor > media)
                    {
                        Console.WriteLine($"O dia {dados[i].dia} Valor: R$ {vetor[i]} foi superor a média mensal");
                    }
                }
            }

            





        }

    }
}