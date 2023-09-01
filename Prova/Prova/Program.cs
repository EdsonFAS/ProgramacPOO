using Prova;
string resposta ;
char resp,queest;

Console.WriteLine("Questão: Qual é o principal objetivo da herança em programação orientada a objetos?\r\n\r\nA) Reduzir a complexidade de um programa, permitindo que classes compartilhem atributos e métodos comuns.\r\nB) Tornar uma classe abstrata, impedindo a criação de objetos a partir dela.\r\nC) Aumentar a segurança do programa, limitando o acesso aos atributos de uma classe.\r\nD) Otimizar o tempo de compilação, eliminando a necessidade de importar bibliotecas externas.\r\nE) Impedir a reutilização de código, forçando a reescrita completa de métodos em cada classe.");
queest = '1';
 resposta=Console.ReadLine().ToUpper();
resp= Convert.ToChar(resposta);
Prova1 x = new Prova1(queest,resp);
x.vefiricar();
