using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio6
{
    [Serializable]
    public class Departamento : Division
    {
        public List<Seccion> secciones;

        public Departamento(string Nombre) : base(Nombre)
        {
            secciones = new List<Seccion>();
        }
    }
}
