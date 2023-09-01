using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Prova
{
    public class Prova1
    {
        public char  questa;
        public char alternativa;
        public int correta, incorreta;
        public Prova1(char quest,char alter) {
        
            this.questa = quest;
            this.alternativa = alter;   
        
        }


        public void vefiricar()
        {
            Gabarito x = new Gabarito();
            Questao y = new Questao();
            
            if (questa== y.questao[0])
            {
                if (alternativa== x.alternativa[3]) {

                    correta++;
                    Console.WriteLine("correta");
                    
                }
                else
                {
                    incorreta++;
                    Console.WriteLine("incorreta");
                }

            }
            if(Convert.ToChar(questa) == y.questao[1])
            {
                if (Convert.ToChar(alternativa) == x.alternativa[1])
                {

                    correta++;
                    Console.WriteLine("correta");

                }
                else
                {
                    incorreta++;
                }

            }
            if (questa== y.questao[2])
            {
                if (alternativa == x.alternativa[3])
                {

                    correta++;
                   
                }
                else
                {
                    incorreta++;
                }

            }
            if (questa == y.questao[3])
            {
                if (alternativa == x.alternativa[0])
                {

                    correta++;
                    
                }
                else
                {
                    incorreta++;
                }

            }








        }
    }
}
