using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Laboratorio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desea utilizar el archivo para cargar la informacion de la empresa?");
            Console.WriteLine("1. Si");
            Console.WriteLine("2. No");
            string respuesta = Console.ReadLine();
            Console.Clear();

            Empresa empresa = null;

            if (respuesta == "1")
            {
                try
                {
                    empresa = Empresa.Load();
                }
                
                catch
                {
                    Console.WriteLine("No hay informacion guardada para cargar");
                    Thread.Sleep(2000);
                    Console.Clear();
                    respuesta = "2";
                }
            }

            if (respuesta == "2")
            {
                Console.WriteLine("Ingrese el nombre de la empresa:");
                string Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el rut de la empresa");
                string Rut = Console.ReadLine();
                empresa = new Empresa(Nombre, Rut);

                //Creamos los datos para la empresa (1 departamento con 1 encargado, 1 seccion con 1 encargado, 2 bloques con 1 encargado y 2 trabajadores cada uno)

                Departamento departamento = new Departamento("Produccion");
                departamento.encargado = new Persona("Marcos", "Plaza", "8499564-9", "Director");

                Seccion seccion = new Seccion("Ensamblaje");
                seccion.encargado = new Persona("Fabian", "Casal", "14555241-9", "Supervisor");

                Bloque bloque1 = new Bloque("Armadores");
                bloque1.encargado = new Persona("Angel", "Fonseca", "7877346-4", "Encargado");
                bloque1.trabajadores.Add(new Persona("Antonia", "Fuente", "5954871-9", "Armador1"));
                bloque1.trabajadores.Add(new Persona("Andres", "Pinto", "6773308-8", "Armador2"));

                Bloque bloque2 = new Bloque("Testers");
                bloque2.encargado = new Persona("Stefan", "Pichara", "13040056-6", "Encargado");
                bloque2.trabajadores.Add(new Persona("Paco", "Bellido", "12830816-4", "Tester1"));
                bloque2.trabajadores.Add(new Persona("Elena", "Moyano", "8323222-6", "Tester2"));

                //Agregamos cada seccion a la lista de la clase superior respectiva
                seccion.bloques.Add(bloque1);
                seccion.bloques.Add(bloque1);

                departamento.secciones.Add(seccion);

                empresa.divisiones.Add(departamento);
                empresa.divisiones.Add(seccion);
                empresa.divisiones.Add(bloque1);
                empresa.divisiones.Add(bloque2);
                
                Empresa.Save(empresa);
            }

            empresa.Info();

            Console.ReadLine();

        }
    }
}
