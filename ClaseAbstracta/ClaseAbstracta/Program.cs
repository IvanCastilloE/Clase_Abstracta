using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpleadoHonorarios EH = new EmpleadoHonorarios("Ivan", "RH", 8000);
            EH.Trabajar();
            Console.WriteLine("Salario por honorarios: {0}", EH.Salario);
            EmpleadoNomina EN = new EmpleadoNomina("Ivan", "Ventas", 5000);
            EN.Trabajar();
            Console.WriteLine("Salario por nomina: {0}", EN.Salario);

            Console.ReadKey();
        }
    }
}
