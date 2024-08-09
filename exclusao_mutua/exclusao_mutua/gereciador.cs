using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
namespace exclusao_mutua
{
    internal class gereciador
    {
        public static bool verifivar()
        {
            string pasta = AppDomain.CurrentDomain.BaseDirectory;
            pasta = pasta.Replace("\\Debug\\net8.0\\", "\\area_critica02.xlsx");
            using (var package = new ExcelPackage(new FileInfo(pasta)))
            {
                // Seleciona a primeira planilha (ou você pode usar o nome da planilha)
                var worksheet = package.Workbook.Worksheets["Planilha1"]; // ou package.Workbook.Worksheets["NomeDaPlanilha"]

                // Lê o valor de uma célula específica (por exemplo, célula A1)
                var cellValue = worksheet.Cells["A1"].Text;

                // Exibe o valor da célula
                
              
                if (cellValue == "true")
                {
                  
                    return true;
                }else
                {
                    return false;}
            }
        }
    }
}
