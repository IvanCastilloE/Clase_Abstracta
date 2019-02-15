﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta
{
    class EmpleadoNomina: Empleado
    {
        public decimal SueldoBase { get; set; }

        public override decimal Salario
        {
            get
            {
                return SueldoBase;
            }
        }

        public EmpleadoNomina(string nombre, string puesto, decimal sueldoBase) : base(nombre, puesto)
        {
            SueldoBase = sueldoBase;
        }
        public override void Trabajar()
        {
            Console.WriteLine("Trabajando por la nomina");
        }
    }
}
