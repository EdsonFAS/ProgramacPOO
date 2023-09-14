
using Voo_passagens;
string escolha = "";
int quant_ass = 0;
DateTime hor = DateTime.Now;
int dia=0, mes=0, ano = 0, hora = 0, minutos=0;
Console.WriteLine("Digite a hora(PM) do voo: ");
hora = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("digite o dia do Voo:");
dia = Convert.ToInt32( Console.ReadLine());
Console.WriteLine("digite o mês do Voo:");
mes = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("digite o ano do Voo:");
ano = Convert.ToInt32(Console.ReadLine());

minutos =  hor.Hour;
int seg = hor.Second;

Voo n = new Voo(dia, mes, ano,hora, minutos,seg);
Console.WriteLine("digite a quantidade de passagens");


quant_ass = Convert.ToInt32(Console.ReadLine());
n.tamanhoAv(quant_ass);

do
{Console.WriteLine("Assentos disponiveis: \n" + n.mostrar(n._acentos));
    Console.WriteLine("Digite a quantidade de passagens deseja comprar:");
    int quant_comp = Convert.ToInt32(Console.ReadLine());
    if (quant_comp <= n._acentos.Length)
    {
        for (int i = 0; i < quant_comp; i++)
        {
            Console.WriteLine("Digite o numero da poltrona:");
            int polt = Convert.ToInt32(Console.ReadLine());

            n.ocupa(polt);

        }
    }
    Console.WriteLine("Digite 's' para realizar uma nova venda:");
    escolha = Console.ReadLine().ToUpper();

} while (escolha == "S");


