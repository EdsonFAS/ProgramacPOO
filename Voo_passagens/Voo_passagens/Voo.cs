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



       public Voo( int dia, int mes, int ano, int horaio, int minutos,int segund) {

            set_Num_Voo();
           _data= new DateTime(ano,mes,dia, horaio, minutos, segund);




        }


        public void set_Num_Voo()
        {
            Random random = new Random();
            _numeroVoo = random.Next(100, 1000);

        }

        public void tamanhoAv(int quant) { 
        
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

        public string mostrar(bool[] acentos)
        {
            string acent= "";
            int coluna=0,cont = 0;
            string asa = "",repor= "",aux="";
            for (int i = 0; i < acentos.Length; i++)
            {


               
               
                    if (i < 9)
                    {
                        if (acentos[i] == false)
                        {

                            acent += $"[\u001b[32m0{i + 1}\u001b[0m]";

                        }
                        if (acentos[i] == true)
                        {

                            acent += $"[\u001b[31m0{i + 1}\u001b[0m]";
                        }
                        
                    }
                    else
                    {
                        if (acentos[i] == false)
                        {

                            acent += $"[\u001b[32m{i + 1}\u001b[0m]";

                        }
                        if (acentos[i] == true)
                        {

                            acent += $"[\u001b[31m{i + 1}\u001b[0m]";
                        }
                        
                    }coluna++;
                    if (coluna == 5){ 
                    acent += "\n";
                    coluna = 0;
                
                
                }
               


            }
           

            return acent;
        }
    }
}
