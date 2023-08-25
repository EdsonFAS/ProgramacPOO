using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecConta
{
    internal class Conta
    {
        public Titular titular;
        public int numeroAgencia, numeroConta;
        public double saldo;



        public Conta(Titular titular,int numeroConta, int numeroAgencia, double saldo)
        {
            setTitular(titular);
            setconta(numeroConta);
            setNumeroAgencia(numeroAgencia);
            setsaldo(saldo);
                       
        }

       public Titular GetTitular() { return titular; }
        public void setTitular(Titular titular)
        {
            this.titular = titular;
        }
       
        
        public int getNumeroAgencia() 
        {  return numeroAgencia; }
        public double getSaldo() 
        {  return saldo; }
        public int getNumeroConta() { 
            return numeroConta; }
      
        public void setNumeroAgencia(int agecia) {
          this.numeroAgencia= agecia;
        }

        public void setconta(int conta)
        {
            this.numeroConta= conta;
        }

        public void setsaldo(double saldo) {
            this.saldo = saldo;
        }
        public double Depositar(double deposito)
        {
            if (deposito > 0)
            {
                saldo += deposito;
                Console.WriteLine("Deposito realizado com SUCESSO!");
                Console.WriteLine($"O Saldo Atual agora é {saldo.ToString("C")}");
            }
            else { Console.WriteLine("Valor invalido!!!"); }
            return saldo;
        }
        public double Retirar(double retirar)
        {
            if (saldo >= retirar) {
                saldo -= retirar;
                Console.WriteLine("Retirada realizado com SUCESSO!");
                Console.WriteLine($"O Saldo Atual agora é {saldo.ToString("C")}");
            }
            if ( retirar<=0)
            {

            }
             else { Console.WriteLine("Saldo Insuficiente!!"); }
            return saldo;
        }

     

    }
}
