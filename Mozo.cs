using System;
namespace Proyecto
{
    public class Mozo
    {
        string _nombre;
        string _apellido;
        string numeroLegajo;
        int cantidadMesas;
        string numeroMesaAsignada;


        public Mozo()
        {

        }

        public Mozo(string nombre, string apellido, string numeroLegajo, int cantidadMesas, string numeroMesaAsignada)
        {
            _nombre = nombre;
            _apellido = apellido;
            this.numeroLegajo = numeroLegajo;
            this.cantidadMesas = cantidadMesas;
            this.numeroMesaAsignada = numeroMesaAsignada;
        }
    }
}
