using System;
using System.Linq;

namespace Job_Rotation____São_Paulo_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite qualquer texto: ");
            char[] chars = Console.ReadLine().ToCharArray();
            char[] invertida = new char[chars.Length];
            int j = chars.Length - 1;

            for (int i = 0; i < chars.Length; i++)
            {
                invertida[j] = chars[i];
                j--;
            }
            Console.WriteLine();
            Console.Write("Texto Invertido: ");
            Console.WriteLine(invertida);

        }
    }
}
