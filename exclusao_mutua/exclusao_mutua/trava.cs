using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static exclusao_mutua.time;


namespace exclusao_mutua
{
    internal class trava


    {
       
        public static  void travar(bool valid)
        {

            string pasta = AppDomain.CurrentDomain.BaseDirectory;
            pasta = pasta.Replace("\\Debug\\net8.0\\", "\\area_critica02.xlsx");



            string caminho = Path.Combine(pasta);
            
             
            using (var package = new ExcelPackage())
            {
                if (valid)
                {
                    var worksheet = package.Workbook.Worksheets.Add("Planilha1");

                    worksheet.Cells[$"A1"].Value = "true";

                    if (valid) { Console.WriteLine("utilizando Zona Critica"); }
                }
                if (!valid)
                {
                    var worksheet = package.Workbook.Worksheets.Add("Planilha1");

                    worksheet.Cells[$"A1"].Value = "false";
                    Console.WriteLine($"Tarefa finalizada!!" +
                        $"\nZona Critica liberada");

                }

                package.SaveAs(new System.IO.FileInfo(caminho));

                                              
            }
       
           
        }
   
    }
}
