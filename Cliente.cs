using System;
namespace Proyecto
{
    public class Cliente
    {

        string _nombreCliente;
        int _mesaCliente;
        string _numeroTelefono;


        public Cliente()
        {
        }

        public string NombreCliente { get => _nombreCliente; set => _nombreCliente = value; }

        public string NumeroTelefono { get => _numeroTelefono; set => _numeroTelefono = value; }

        public int MesaCliente { get => _mesaCliente; set => _mesaCliente = value; }


    }



}
