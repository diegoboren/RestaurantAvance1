using System;
namespace Proyecto
{
    public class Mozo
    {
        private string numeroLegajo;
        private int cantidadMesas;
        private Mesa MesaAsignada;
        private Persona mozo;

        public Mozo()
        {
        }

        public Mozo(string numeroLegajo, int cantidadMesas, Mesa mesaAsignada)
        {
            this.numeroLegajo = numeroLegajo;
            this.cantidadMesas = cantidadMesas;
            MesaAsignada = mesaAsignada;
        }



        
    

        
    }
}
