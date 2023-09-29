using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att_pedagio
{
    public class Veiculo:pedagio
    {
        public string _placa;
        public int _qtdeixos;
        public string _categoria;


        public Veiculo(int tipo,string placa, int eixos,string categoria)
        {
            base._tipo = tipo;
            _placa = placa;
            _qtdeixos = eixos;
            _categoria= categoria;
        }
        
        


    }
}
