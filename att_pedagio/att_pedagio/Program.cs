using att_pedagio;

Console.WriteLine("digite a placa:");
string placa = Console.ReadLine();
Console.WriteLine("digite a categoria (passeio,utilitario,onibus,caminhão):");
string categ = Console.ReadLine();
Console.WriteLine("digite a quantidade de eixos:");
int eixos = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Escolha: \n1 para pessoa comum \n2 para pessoa juridica \n3 para pessoa oficial");
int tipo = Convert.ToInt32(Console.ReadLine());

Veiculo n = new Veiculo(tipo, placa, eixos, categ);

n.calcularpedagio(n._categoria,n._qtdeixos);
n.desconto(n._tipo);


Console.WriteLine($"placa do veiculo: {n._placa}  \ncategoria: {n._categoria} \nquantidade de eixos: {n._qtdeixos} \nvalor do pedagio: {n._precopedagio.ToString("N")} \nValor desconto: {n._valorfinal} ");
