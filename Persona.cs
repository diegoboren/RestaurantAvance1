using System;
namespace Proyecto
{
    public class Persona
    {

        private string _nombre;
        private string _apellido;

        public Persona()
        {
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
    }
}
