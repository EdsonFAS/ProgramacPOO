using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    internal class Gabarito
    {
        public List<char>alternativa =new List<char>();
        
       public Gabarito() {
            alternativa.Add('A');
            alternativa.Add('B');
            alternativa.Add('C');
            alternativa.Add('D');
            alternativa.Add('E');
        }    
       
    }
}
