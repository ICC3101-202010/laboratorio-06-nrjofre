using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio6
{
    [Serializable]
    public class Seccion : Division
    {
        public List<Bloque> bloques;

        public Seccion(string Nombre) : base(Nombre)
        {
            bloques = new List<Bloque>();
        }
    }
}
