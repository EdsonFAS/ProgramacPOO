
using gabarito_prova;

string escolha = "";
List<char>alternativa = new List<char>();
List<prova>provas= new List<prova>();

do {
    alternativa.Clear();
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine($"Digite a resposta da {i+1}º questão");
        char alter = Convert.ToChar(Console.ReadLine().ToUpper());

        alternativa.Add(alter);


    }
    prova prova =  new prova();

    prova.respostaAluno(alternativa);
    Console.WriteLine($"Seus Acertos: {prova.acertos()}"); 
    Console.WriteLine($"Sua nota: {prova.Nota(prova.acerto)}"); 

    provas.Add(prova);
    

    Console.WriteLine("Digite 'S' para adicionar mais uma prova");
    escolha = Console.ReadLine();

} while (escolha.ToUpper()=="S");
Console.WriteLine($"A maior nota é "+prova.maior(provas));