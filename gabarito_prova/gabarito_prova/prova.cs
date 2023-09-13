using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gabarito_prova
{
    internal class prova
    {

        public Gabarito Gabarit ;
        public List<char> alternativas = new List<char>();
        public int nota;
        public int acerto;


        public prova() {

            Gabarit = new Gabarito();

        }


        public int acertos() {
             acerto = 0;
            for (int i = 0; i < alternativas.Count; i++)
            {


                if (alternativas[i] == Gabarit.gabaritoList[i])
                { acerto++;             
                
                }

            }

            return acerto;
        }


        public int Nota(int acertos) {
            nota = 0;
            nota = acerto * 2;
        
        return nota;
        
        }
        public void respostaAluno(List<char> alternat)
        {


            this.alternativas= alternat;

        }
        public static int maior(List<prova> provas)
        {
            int notamaior=0;
       // notamaior = provas.Max
            
            foreach (prova pro in provas)
            {
                if (notamaior < pro.nota)
                {
                    notamaior = pro.nota;
                    
                }


            }

            return notamaior;
        }

    }
}
