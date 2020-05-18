using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio6
{
    [Serializable]
    public class Area : Division
    {
        public List<Departamento> departamentos;

        public Area (string Nombre) : base(Nombre)
        {
            departamentos = new List<Departamento>();
        }
    }
}
