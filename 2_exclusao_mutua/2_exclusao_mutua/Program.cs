

using OfficeOpenXml;
using static _2_exclusao_mutua.time;
static bool verifivar()
{

    string pasta = "C:\\Users\\Edson\\source\\repos\\exclusao_mutua\\exclusao_mutua\\bin\\area_critica02.xlsx";
    using (var package = new ExcelPackage(new FileInfo(pasta)))
    {

        
        var worksheet = package.Workbook.Worksheets["Planilha1"]; 

     
        var cellValue = worksheet.Cells["A1"].Text;

    

        if (cellValue == "true")
        {
            return true;
        }
        else { return false; }
    }
}

while (verifivar() != false)
{
    Console.WriteLine("ocupado!!  aguarde");
    bool result = await EsperarUmMinuto(7000);
  
}

Console.WriteLine("utilizando zona critica");

bool liberar = await EsperarUmMinuto(3000);
Console.WriteLine("zona critica liberada");