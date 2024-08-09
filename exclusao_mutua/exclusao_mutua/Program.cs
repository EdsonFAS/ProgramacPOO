using OfficeOpenXml;
using static exclusao_mutua.trava;
using static exclusao_mutua.gereciador;
using static exclusao_mutua.time;

internal class Program
{
    private static async Task Main(string[] args)
    {
       
        do
        {
            travar(false);
            bool verif = verifivar();
            if (verif == false)
            {
                Console.WriteLine($"Zona Critica está live");

                travar(true);

                bool result = await EsperarUmMinuto(40000);
                if (result == true)
                {
                    verif = verifivar();
                    if (verif == true)
                    {

                        travar(false);

                    }
                }
            } bool reiniciar = await EsperarUmMinuto(20000);

        } while (!verifivar());
       
    }
}