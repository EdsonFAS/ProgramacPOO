using VerificarCPF;

Console.WriteLine("-----Verificador de CPD-----");
Console.WriteLine("Digite o CPF Que deseja verificar:");
if (Pessoa.Validar("03892501203 "))
{
    Console.WriteLine("Valido");

}
Console.ReadKey();