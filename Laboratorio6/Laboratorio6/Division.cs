using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio6
{
    [Serializable]
    public class Division
    {
        string Nombre;

        public Persona encargado;
        public List<Persona> trabajadores;

        public Division(string Nombre)
        {
            this.Nombre = Nombre;
            trabajadores = new List<Persona>();
        }

        public override string ToString()
        {
            string datos = $"[{this.GetType().Name}] {Nombre}\n";

            datos += $"Encargado: {encargado.Nombre}\n";
            datos += "Trabajadores:";

            foreach (Persona trabajador in trabajadores)
            {
                datos += $"\n{trabajador.Nombre} - {trabajador.Cargo}";
            }

            return datos;
        }
    }
}
