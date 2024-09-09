using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoMorse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Menú para el usuario
            Console.WriteLine(@"Seleccione una opción:
1. Convertir texto a código Morse
2. Convertir código Morse a texto
3. Salir");

            string opciónUsuario = Console.ReadLine();
        }
    }
}
