using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att_pedagio
{
    public class pedagio
    {
        public int _tipo;

        public double _precopedagio;
        public double _valorfinal;
              
       

        public void calcularpedagio(string categoria, int eixos)
        {
          double valoreixos=0,taxa = 0;

            if (categoria.ToUpper() == "PASSEIO")
            {
                this._precopedagio= eixos*3.00;
                
            }
            if (categoria.ToUpper()=="UTILITARIO") {

                valoreixos = eixos * 3.50;
              taxa= valoreixos * (2 / 100);
                _precopedagio = valoreixos + taxa;

            }
            if (categoria.ToUpper()=="ONIBUS") {

                valoreixos = eixos * 5.00;
                taxa = valoreixos * (5 / 100);
                _precopedagio = valoreixos + taxa;
            }
            if (categoria.ToUpper() == "CAMINHÃO")
            {

                valoreixos = eixos * 7;
                taxa = valoreixos * (10 / 100);
                _precopedagio = valoreixos + taxa;
            }

        }

        public void desconto(int tipo) {

            double valor = 0;
            if (tipo == 1)
            {
                _tipo = tipo;
                _valorfinal =  0;
            }
            if (tipo==2)
            {
                this._tipo = tipo;
                valor = _precopedagio * (5 / 100);
                _valorfinal= _precopedagio-valor;
            }
            if (tipo == 3)
            {
                this._tipo = tipo;
              
                _valorfinal = _precopedagio;
                
            }
        
        
        
        }

    }
}
