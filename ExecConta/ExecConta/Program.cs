using ExecConta;
using System.Drawing;

string op = "";
int escolha = -1;
int listaCount = 0;

List<Conta> lista = new List<Conta>();


do
{
    Console.WriteLine("\nEscolha uma das Opções abaixo " +
       "\n 1 - para cadastra outra conta" +
       "\n 2 - para para depositar" +
       "\n 3 - para realizar retirada" +
       "\n 4 - para listar todas contas" +
       "\n 0 - para sair\"");
    while (!int.TryParse(Console.ReadLine(), out escolha))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Digite apenas Numero!!");
        Console.ResetColor();
        Console.WriteLine("\nEscolha uma das Opções abaixo " +
    "\n 1 - para cadastra outra conta" +
    "\n 2 - para para depositar" +
    "\n 3 - para realizar retirada" +
    "\n 4 - para listar todas contas" +
    "\n 0 - para sair");
    }
    switch (escolha)
    { case 1:
            do
            {
                Console.WriteLine("Cadastrar  conta");
                
                string nome = "",cpf="",email="";
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
                    Console.WriteLine("Digite o CPF:");
                    cpf=Console.ReadLine();
                Console.WriteLine("Digite o Email:");
                email=Console.ReadLine();
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
                Titular t= new Titular(nome, cpf, email);
                Conta Cont = new Conta(t, numeroConta, agencia, saldo);
                
                lista.Add(Cont);
                Console.WriteLine("Deseja cadastrar outra conta ? (Digite S para 'sim' ou N para 'não')");
                op = Console.ReadLine();
            } while (op.ToUpper() == "S" || op.ToUpper() == "SIM");

            break;
        case 2:
            int Nconta = 0;
            Console.WriteLine("Digite o numero da conta:");
            while (!int.TryParse(Console.ReadLine(), out Nconta))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Digite apenas Numero!!");
                Console.ResetColor();
                Console.WriteLine("Digite o numero da conta:");
            } if (listaCount != 0)
                {
            foreach (Conta conta in lista)
            {
                listaCount= lista.Count;
               
                    if (Nconta == conta.numeroConta)
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
                    }if(Nconta!=conta.numeroConta) { Console.WriteLine("Conta não existe!!"); }
               
                
            } }else { Console.WriteLine("nenhuma conta cadastrada"); }
            break;
        case 3:

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

                if (Nconta == conta.numeroConta)
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
                if(Nconta != conta.numeroConta) { Console.WriteLine("Conta não existe!!"); }
            }
            break;
       
        case 4:

            listaCount = lista.Count;
            if (listaCount != 0)
            {
                foreach (Conta item in lista)
                {
                    Console.WriteLine($"Nome do Titular: {item.GetTitular().getNome()} \nConta: {item.getNumeroConta()} \nAgencia: {item.getNumeroAgencia()} \nSaldo:{item.getSaldo()}");
                }
            }else { Console.WriteLine("nenhuma conta cadastrada"); }
            break;
        case 5:
            Nconta = 0;
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
                listaCount = lista.Count;
                if (listaCount != null)
                {
                    if (Nconta == conta.numeroConta)
                    {
                        Console.WriteLine($"Nome do Titular: {conta.GetTitular().getNome()} \nConta: {conta.getNumeroConta()} \nAgencia: {conta.getNumeroAgencia()} \nSaldo:{conta.getSaldo()}");
                        int detalhe = 0;
                        Console.WriteLine("Para visualizar detalhes do titular digite '1':");

                        detalhe = int.Parse(Console.ReadLine());
                        if (detalhe==1) { Console.WriteLine($"Nome do Titular: {conta.GetTitular().getNome()} \nCPF do titular: {conta.GetTitular().getCpf()} \nEmail do titular: {conta.GetTitular().getEmail()}"); }
                    }

                }
                else { Console.WriteLine("Conta não existe!!"); }

            }
            break;
        case 0:
            break;
        default:
            Console.WriteLine("Opção Incorreta!");
            break;
    }
} while (escolha != 0);







