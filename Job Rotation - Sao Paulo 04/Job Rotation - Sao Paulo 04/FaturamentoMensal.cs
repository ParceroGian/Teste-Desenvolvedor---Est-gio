using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Rotation___Sao_Paulo_04
{
    class FaturamentoMensal
    {
        public double Sp;
        public double Rj;
        public double Mg;
        public double Es;
        public double Outros;
        public double Total;

        public void Porcentual()
        {
            Total = Sp + Rj + Mg + Es + Outros;

            Console.WriteLine($"SP {Sp * 100 / Total:F2}% ");
            Console.WriteLine($"RJ {Rj * 100 / Total:F2}% ");
            Console.WriteLine($"MG {Mg * 100 / Total:F2}% ");
            Console.WriteLine($"ES {Es * 100 / Total:F2}% ");
            Console.WriteLine($"Outros {Outros * 100 / Total:F2}% ");
        }


    }
}
