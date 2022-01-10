using System;

namespace Job_Rotation___Sao_Paulo_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FaturamentoMensal fat = new FaturamentoMensal();

            Console.WriteLine("Entre com o faturamente de cada mês correspondente.");
            Console.Write("SP - R$ ");
            fat.Sp = Double.Parse(Console.ReadLine());

            Console.Write("RJ - R$ ");
            fat.Rj = Double.Parse(Console.ReadLine());

            Console.Write("MG - R$ ");
            fat.Mg = Double.Parse(Console.ReadLine());

            Console.Write("ES - R$ ");
            fat.Es = Double.Parse(Console.ReadLine());

            Console.Write("Outros - R$ ");
            fat.Outros = Double.Parse(Console.ReadLine());
            Console.WriteLine();

            fat.Porcentual();



        }
    }
}
