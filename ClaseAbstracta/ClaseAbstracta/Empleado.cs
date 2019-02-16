using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta
{
    abstract class Empleado //Definimos la palabra reservada abstract
    {
        public string Nombre { get; set; }
        public string Puesto { get; set; }
        public abstract decimal Salario { get; } //Se calculará desde una subclase por eso es abstracta

        public Empleado(string nombre, string puesto)
        {
            Nombre = nombre;
            Puesto = puesto;
        }

        public void Saludar()
        {
            Console.WriteLine("Hola bb mi nombre es: {0} y mi puesto: {1}", Nombre, Puesto);
        }

        public abstract void Trabajar();
    }
}
