using System;
namespace Proyecto
{
    public class Cliente
    {
            private Persona cliente;
            private int _mesaCliente;
            private string _numeroTelefono;
            private bool _pedirCuenta;
            private Mesa hayMesa;


            public Cliente()
            {
            }

        public string NombreCliente { get => _nombreCliente; set => _nombreCliente = value; }

        public string NumeroTelefono { get => _numeroTelefono; set => _numeroTelefono = value; }

        public int MesaCliente { get => _mesaCliente; set => _mesaCliente = value; }


        public bool pedirMesa()
        {
            if (hayMesa.EstaOcupada = true)
            {

                return true;
            } else if (hayMesa.EstaOcupada = false)
            {
                return false;
            }

            //Este metodo esta mal 

        }




        public bool PedirCuenta ()

        {
            return _pedirCuenta = true;
        }


    }
}

