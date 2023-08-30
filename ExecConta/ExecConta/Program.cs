using ExecConta;
using System.Drawing;
using VerificarCPF;

string op = "";
string escolha;
int escol ;
int Nconta = 0, listCont = 0;

List<Conta> lista = new List<Conta>();


do
{
    do
    {
        
        Console.WriteLine("\n=========MENU=========" +
            "\nEscolha uma das Opções abaixo " +
           "\n 1 - para Cadastra outra conta" +
           "\n 2 - para Depositar" +
           "\n 3 - para Realizar retirada" +
           "\n 4 - para Listar todas contas" +
           "\n 5 - para Consultar conta" +
           "\n 0 - para Sair\"");
        escolha= Console.ReadLine();
        if(!int.TryParse(escolha.ToString(), out escol)) {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Digite apenas Numero!!");
        Console.ResetColor(); 
        }
    } while (!int.TryParse(escolha, out escol));Console.Clear();

    switch (Convert.ToInt32( escolha))
    {
        case 1:
            do
            {
                Console.WriteLine("Cadastrar  conta");

                string nome = "", cpf = "", email = "";
                int agencia = 0, numeroConta = 0;
                double saldo = 0, deposito = 0, retirada = 0;


                do
                {
                    Console.WriteLine("Digite o nome do titular: ");
                    nome = Console.ReadLine();
                    if (string.IsNullOrEmpty(nome))
                    {
                        Console.WriteLine("Nome invalido!!!");
                    }
                } while (string.IsNullOrWhiteSpace(nome));

                do
                {
                    Console.WriteLine("Digite o CPF:");
                    cpf = Console.ReadLine();
                    if (false == Pessoa.Validar(cpf))
                    {
                        Console.WriteLine("Invalido");
                    }
                } while (false == Pessoa.Validar(cpf));

                Console.WriteLine("Digite o Email:");
                email = Console.ReadLine();
                Console.WriteLine("Digite o numero da conta:");
                while (!int.TryParse(Console.ReadLine(), out numeroConta))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Digite apenas Numero!!");
                    Console.ResetColor();
                    Console.WriteLine("Digite o numero da conta:");
                }
                Console.WriteLine("Digite o numero da Agencia:");
                while (!int.TryParse(Console.ReadLine(), out agencia))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Digite apenas Numero!!");
                    Console.ResetColor();
                    Console.WriteLine("Digite o numero da Agencia:");
                }
                Console.WriteLine("Digite saldo da contar:");
                while (!double.TryParse(Console.ReadLine(), out saldo))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Digite apenas Numero!!");
                    Console.ResetColor();
                    Console.WriteLine("Digite saldo da contar:");
                }
                Titular t = new Titular(nome, cpf, email);
                Conta Cont = new Conta(t, numeroConta, agencia, saldo);

                lista.Add(Cont);
                listCont = lista.Count;
                Console.WriteLine("Deseja cadastrar outra conta ? (Digite S para 'sim' ou N para 'não')");
                op = Console.ReadLine();
            } while (op.ToUpper() == "S" || op.ToUpper() == "SIM");

            break;
        case 2:

            if (listCont != 0)
            {
                Console.WriteLine("Digite o numero da conta:");
                while (!int.TryParse(Console.ReadLine(), out Nconta))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Digite apenas Numero!!");
                    Console.ResetColor();
                    Console.WriteLine("Digite o numero da conta:");
                }
                foreach (Conta conta in lista)
                {

                    if (Nconta == conta.getNumeroConta())
                    {
                        double valor = 0;
                        Console.WriteLine("Digite o valor do deposito:");
                        while (!double.TryParse(Console.ReadLine(), out valor))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Digite apenas Numero!!");
                            Console.ResetColor();
                            Console.WriteLine("Digite o valor que deseja retirar:");
                        }
                        conta.Depositar(valor);
                    }
                    else { Console.WriteLine("Conta não existe!!"); }
                }
            }
            else
            {
                Console.WriteLine("Nenhuma conta cadastrada ainda!!!");
            }
            break;
        case 3:
            if (listCont != 0)
            {
                Console.WriteLine("Digite o numero da conta:");
                while (!int.TryParse(Console.ReadLine(), out Nconta))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Digite apenas Numero!!");
                    Console.ResetColor();
                    Console.WriteLine("Digite o numero da conta:");
                }
                foreach (Conta conta in lista)
                {

                    if (Nconta == conta.getNumeroConta())
                    {
                        double valor = 0;
                        Console.WriteLine("Digite o valor que deseja retirar:");
                        while (!double.TryParse(Console.ReadLine(), out valor))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Digite apenas Numero!!");
                            Console.ResetColor();
                            Console.WriteLine("Digite o valor que deseja retirar:");
                        }
                        conta.Retirar(valor);
                    }
                    else { Console.WriteLine("Conta não existe!!"); }

                }
            }
            else
            {
                Console.WriteLine("Nenhuma conta cadastrada ainda!!!");
            }
            break;

        case 4:

            if (listCont != 0)
            {
                foreach (Conta item in lista)
                {
                    Console.WriteLine($"Nome do Titular: {item.GetTitular().getNome()} \nConta: {item.getNumeroConta()} \nAgencia: {item.getNumeroAgencia()} \nSaldo: {item.getSaldo().ToString("C")}");
                }
            }
            else
            {
                Console.WriteLine("Nenhuma conta cadastrada ainda!!!");
            }

            break;
        case 5:

            if (listCont != 0)
            {
                Console.WriteLine("Digite o numero da conta:");
                while (!int.TryParse(Console.ReadLine(), out Nconta))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Digite apenas Numero!!");
                    Console.ResetColor();
                    Console.WriteLine("Digite o numero da conta:");
                }
                foreach (Conta item in lista)
                {
                    if (Nconta == item.getNumeroConta())
                    {
                        Console.WriteLine($"Nome do Titular: {item.GetTitular().getNome()} \nConta: {item.getNumeroConta()} \nAgencia: {item.getNumeroAgencia()} \nSaldo:{item.getSaldo().ToString("C")}");

                        int detalhe = 0;
                        Console.WriteLine("Para visualizar detalhes do titular digite '1':");

                        detalhe = int.Parse(Console.ReadLine());


                        Console.WriteLine($"=======Dados do Titular=======" +
                            $"\nNome do Titular: {item.GetTitular().getNome()} \nCPF do titular: {item.GetTitular().getCpf()} \nEmail do titular: {item.GetTitular().getEmail()}");
                    }
                    else
                    {
                        Console.WriteLine("Conta não existe!!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Nenhuma conta cadastrada ainda!!!");
            }

            break;
        case 0:
            break;
        default:
            Console.WriteLine("Opção Incorreta!");
            break;
    }
} while (Convert.ToInt32( escolha) != 0);







