using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPOOPractica2.Entidades
{
    class EmpleadoBaseMasComision: EmpleadoPorComision
    {
        private double salBase;
        public EmpleadoBaseMasComision()
        {

        }
        public EmpleadoBaseMasComision(string ced, string nom, string ape, char sexo, int edad, string ciudad, string tipo, double ventBrut, double porcentaje, double salBase)
            : base(ced, nom, ape, sexo, edad, ciudad, tipo, ventBrut, porcentaje)
        {
            this.SalBase = salBase;
        }
        public override double CalcularSueldo()
        {
            return (VentBrut * Porcentaje / 100) + salBase + (salBase*0.1);
        }
        public double SalBase { get => salBase; set => salBase = value; }
        
    }
    
}
