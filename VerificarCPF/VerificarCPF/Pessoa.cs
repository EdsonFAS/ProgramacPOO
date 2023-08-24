using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificarCPF
{
    public static class Pessoa
    {
        private static string cpf { get; set; }

        
        public static void Validar(string cpf)
        {
            cpf = cpf.Replace(".","");
            cpf = cpf.Replace("-", "");
            int soma = 0, decr = 10, resto=0, result2=0, soma2=0;

            
            if (cpf.Length == 11)
            {
                for (int i = 0;i < 9; i++) {
                    soma += decr *Convert.ToInt32(cpf[i].ToString());
                   
                   decr--;
                }
                if(soma%11==0 || soma%11==1) {

                    if (0 == Convert.ToInt32(cpf[9].ToString())) {
                        decr = 11;
                        for (int i = 0; i < 10; i++)
                        {
                            soma2 += decr * Convert.ToInt32(cpf[i].ToString());

                             decr--;
                        }

                        if (soma2%11==0 || soma2 % 11 == 1)
                        { if (0 == Convert.ToInt32(cpf[10].ToString()))
                            {
                                Console.WriteLine("valido!!");
                            }
                        }

                      
                        result2= soma2 % 11;

                        result2 = 11 - result2;
                        if (result2 == Convert.ToInt32(cpf[10].ToString()))
                        {
                            Console.WriteLine("Valido");
                        }
                        else
                        {
                            Console.WriteLine("invalido");
                        }
                    }
                   

                }
               else
                {
                    resto= soma%11;

                    resto = 11 - resto;
                        if(resto== Convert.ToInt32(cpf[9].ToString()))
                    {
                        decr = 11;
                        for (int i = 0; i < 10; i++)
                        {
                            soma2 += decr * Convert.ToInt32(cpf[i].ToString());

                            decr--;
                        }

                        if (soma2 % 11 == 0 || soma2 % 11 == 1)
                        {
                            if (0 == Convert.ToInt32(cpf[10].ToString()))
                            {
                                Console.WriteLine("valido!!");
                            }
                        }


                        result2 = soma2 % 11;

                        result2 = 11 - result2;
                        if (result2 == Convert.ToInt32(cpf[10].ToString()))
                        {
                            Console.WriteLine("Valido");
                        }
                        else
                        {
                            Console.WriteLine("invalido");
                        }




                    }
                    else
                    {
                        Console.WriteLine("invalido");
                    }

                }
              

            }
            else { Console.WriteLine("Invalido!!"); }   
        }



        
    }
}
