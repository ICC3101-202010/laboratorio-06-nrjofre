using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio6
{
    [Serializable]
    public class Persona
    {
        public string Nombre;
        public string Apellido;
        public string Rut;
        public string Cargo;

        public Persona(string Nombre, string Apellido, string Rut, string Cargo)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Rut = Rut;
            this.Cargo = Cargo;
        }


    }
}
