using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace SettingsDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            //var context = new SettingsContext();
            //var settings = context.Settings.ToList();

            //var provider = new CSharpCodeProvider();
            //provider.CompileAssemblyFromSource(new CompilerParameters { GenerateInMemory = true }, "public class alborghetti{ public int dalborgaJaMorreu =0; }");

            var diretorio = @"C:\Users\thiago.barnabe\Documents\Source\Drafts\SettingsDynamic\ClassLibrary1\NewFolder\";

            if (Directory.Exists(diretorio))
            {
                var filePaths = Directory.GetFiles(diretorio);
                foreach (var filePath in filePaths)
                {
                    File.Delete(filePath);
                }

                Directory.Delete(diretorio);
            }

            Directory.CreateDirectory(diretorio);
            while (!Directory.Exists(diretorio))
                Thread.Sleep(10);

            //using (StreamWriter sw = File.CreateText(Path.Combine(diretorio, "Settings.cs")))
            //{
            //    sw.WriteLine("public static class Settings");
            //    sw.WriteLine("{");
            //    StringBuilder sb = new StringBuilder();
            //    sb.AppendLine("public static void Reset()");
            //    sb.AppendLine("{");
                

            //    foreach (var setting in settings)
            //    {
            //        sw.Write("public static ");
            //        switch (setting.Type)
            //        {                        
            //            case "String":
            //                sw.WriteLine("string " + setting.SettingID + " {get; private set;} = \"" + setting.StringValue + "\";");
            //                sb.AppendLine("this." + setting.SettingID + " = context.Settings(x=>x.SettingID == \"" + setting.SettingID + "\").FirstOrDefault().StringValue");
            //                break;
            //            case "DateTime":
            //                sw.WriteLine("DateTime = " + setting.SettingID + " = \"" + setting.DateTimeValue + "\";");
            //                break;
            //            case "Integer":
            //                sw.WriteLine("int = " + setting.SettingID + " = \"" + setting.IntegerValue + "\";");
            //                break;
            //            case "Numeric4":
            //                sw.WriteLine("double = " + setting.SettingID + " = \"" + setting.Numeric4Value + "\";");
            //                break;
            //            default:
            //                break;
            //        }
                    
            //    }
            //    sb.AppendLine("}");
            //    sw.WriteLine(sb);

            //    sw.WriteLine("}");
            //}




            //reset
            
            

            //var teste = File.Create(@"C:\Users\thiago.barnabe\Documents\Source\Drafts\SettingsDynamic\ClassLibrary1\teste.cs");

            Console.WriteLine("Hello World!");
        }
    }
}
