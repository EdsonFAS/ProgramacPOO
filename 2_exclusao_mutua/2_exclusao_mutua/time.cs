using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_exclusao_mutua
{
    internal class time
    {

        public static async Task<bool> EsperarUmMinuto(int number)
        {
            // Aguarda 1 minuto (60.000 milissegundos)
            await Task.Delay(number);

            // Retorna true após 1 minuto
            return true;
        }
    }
}
