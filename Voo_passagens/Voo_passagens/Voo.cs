using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voo_passagens
{
    internal class Voo
    {
        public int _numeroVoo = 0, _numeroPass;
        public DateTime _data;
        public bool[] _acentos;



      //  public Voo(int numVoo, int numPass, string dia, string mes, string ano, string horaio, int acentos) {
        
        
        
        
        
       // }

        public Voo(int quant) { 
        
            _acentos= Enumerable.Repeat(false,quant).ToArray();


        }
        public bool verificar(int numeroAc)
        {
            if (_acentos[numeroAc-1]==true)
            {
                return true;

            }

            return false;

        }

        public bool ocupa(int numeroAc)
        {
            if (verificar(numeroAc)==true)
            {
                return false;

            }

            _acentos[numeroAc-1]= true;

            return true;
        }
        public int vaga(bool[] acentos)
        {
            int vaga = 0;
            for (int i = 0;i < acentos.Length;i++)
            {
                if (acentos[i] == false)
                {
                   vaga++;

                }


            }

            return vaga;
        }

        public string[] mostrar(bool[] acentos)
        {
            string[] acent= new string[acentos.Length];
           for (int i = 0;i < acent.Length; i++) {
                if (acentos[i] == false)
                {

                    acent[i] = $"[\u001b[32m{i+1}\u001b[0m]";

                }
                if (acentos[i] == true)
                {

                    acent[i] = $"[\u001b[31m{i + 1}\u001b[0m]";
                }
            
            
            
            
            }




            return acent;
        }
    }
}
