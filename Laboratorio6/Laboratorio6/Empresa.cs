using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Laboratorio6
{
    [Serializable]
    public class Empresa
    {
        string Nombre;
        string Rut;
        public List<Division> divisiones;

        public Empresa(string Nombre, string Rut)
        {
            this.Nombre = Nombre;
            this.Rut = Rut;
            divisiones = new List<Division>();
        }

        public static void Save(Empresa empresa)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("empresa.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, empresa);

            stream.Close();
        }

        public static Empresa Load()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("empresa.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            Empresa empresa = (Empresa)formatter.Deserialize(stream);

            stream.Close();
            return empresa;
        }

        public override string ToString()
        {
            return $"Empresa: {Nombre} \n" +
                $"Rut: ({Rut})";
        }

        public void Info()
        {
            Console.WriteLine($"{this}\n");
            foreach (Division division in divisiones)
                Console.WriteLine($"{division}\n");
        }
    }
}
