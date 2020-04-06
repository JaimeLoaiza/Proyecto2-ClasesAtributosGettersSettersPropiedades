using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreaciónClasesAtributosGettersSettersPropiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona objeto = new Persona();
            Console.WriteLine("Escriba el Nombre");
            objeto.SetNombre(Console.ReadLine());
            Console.WriteLine("Escriba el Apellido");
            objeto.Apellido = Console.ReadLine();
            Console.WriteLine("Escriba el numero del Documento");
            objeto.numeroDeDocumento = Console.ReadLine();
            Console.WriteLine("Los Datos Ingresados Fueron:");
            Console.WriteLine("Nombre {0}", objeto.GetNombre());
            Console.WriteLine("Apellido {0}", objeto.Apellido);
            Console.WriteLine("Número de Documento {0}", objeto.numeroDeDocumento);
            Console.ReadKey();
        }
    }
}
