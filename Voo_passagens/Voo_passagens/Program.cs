
using Voo_passagens;


Console.WriteLine("digite a quantidade de passagens");

int quant = 0;
quant = Convert.ToInt32(Console.ReadLine());


if (quant != 0)
{
    Voo n = new Voo(quant);


for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Digite o numero da poltrona:");
    int polt = Convert.ToInt32(Console.ReadLine());

    n.ocupa(polt);

}
string[] mostrar= new string [n._acentos.Length];
mostrar= n.mostrar(n._acentos);
    int coluna1 = 0;
    string m = "";
for (int i = 0;i < mostrar.Length; i++)
{
        if (coluna1 <6)
        {
            m += $"{mostrar[i]}";
            coluna1++;

        }
        else
        {
            m += $"\n";
            coluna1 = 0;
        }




}
Console.WriteLine(m);
}