using System;

namespace Job_Rotation____São_Paulo_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fibonacci = new Fibonacci();
            int entrada;

            Console.Write("Entre com um valor: ");
            entrada = int.Parse(Console.ReadLine());

            fibonacci.Apresentar(entrada);

        }
    }
}
