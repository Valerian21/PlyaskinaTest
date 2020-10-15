using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InspectorLib;

namespace PlyaskinaTest
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                // Запускаются методы из библиотеки 
                FunctionInsp.GetInspector();             
               FunctionInsp.GetСarInspection();
                //Т.к метод не стаcтический, 
                //его можно вызвать только через экземпляр класса.
                var GWor = new FunctionInsp();
                GWor.GetWorker();
                var Insp = new FunctionInsp();
               Insp.SetInspector("");
               FunctionInsp.GenerateNumber(0,"",0);
                var AWor = new FunctionInsp();
               AWor.AddWorker();
               Console.ReadLine();
            }

        }
    }
}
