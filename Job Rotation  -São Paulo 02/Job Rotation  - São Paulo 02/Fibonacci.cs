using System;


namespace Job_Rotation____São_Paulo_02
{
    public class Fibonacci
    {
        private int FiboX = 0;
        private int FiboY = 1;
        public int Fibo = 0;

        public void Apresentar(int entrada)
        {
            while (entrada > Fibo)
            {
                int temp;
                Fibo = FiboX + FiboY;
                temp = FiboX;
                FiboX = FiboY;
                FiboY = Fibo;
            }

            if (entrada == Fibo)
            {
                Console.WriteLine($"O numero Informado ({entrada}) Pertence a sequência Fibonacci.");
            }
            else
            {
                Console.WriteLine($"O numero Informado ({entrada}) não Pertence a sequência Fibonacci.");
            }
        }


    }



}




