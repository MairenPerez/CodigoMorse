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
            while (true)
            {
                // Menú para el usuario
                Console.WriteLine(@"Seleccione una opción:
    1. Convertir texto a código Morse
    2. Convertir código Morse a texto
    3. Salir");

                if (!int.TryParse(Console.ReadLine(), out int opcion))
                {
                    Console.WriteLine("Opción inválida. Ingresa un número del 1 al 3.");
                    continue;
                }

                if (opcion == 3) // Si la opción es 3, salir del programa
                    break;

                switch (opcion)
                {
                    case 1:
                        CodigoMorse();
                        break;
                    case 2:
                        MorseATexto();
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Ingresa un número del 1 al 3.");
                        break;
                }
            }
        }

        private static readonly Dictionary<char, string> codigoMorseDiccionario = new Dictionary<char, string>()
            {
            // Abecedario y números en código Morse
                {'A', ".-"}, {'B', "-..."}, {'C', "-.-."}, {'D', "-.."}, {'E', "."},
                {'F', "..-."}, {'G', "--."}, {'H', "...."}, {'I', ".."}, {'J', ".---"},
                {'K', "-.-"}, {'L', ".-.."}, {'M', "--"}, {'N', "-."}, {'O', "---"},
                {'P', ".--."}, {'Q', "--.-"}, {'R', ".-."}, {'S', "..."}, {'T', "-"},
                {'U', "..-"}, {'V', "...-"}, {'W', ".--"}, {'X', "-..-"}, {'Y', "-.--"},
                {'Z', "--.."}, {'0', "-----"}, {'1', ".----"}, {'2', "..---"}, {'3', "...--"},
                {'4', "....-"}, {'5', "....."}, {'6', "-...."}, {'7', "--..."}, {'8', "---.."},
                {'9', "----."}, {' ', "/"}
            };

        private static void CodigoMorse()
        {
            Console.WriteLine("Ingrese el texto a convertir a código Morse:");
            string texto = Console.ReadLine().ToUpper();

            StringBuilder codigoMorse = new StringBuilder();
            foreach (char c in texto)
            {
                if (codigoMorseDiccionario.ContainsKey(c))
                {
                    codigoMorse.Append(codigoMorseDiccionario[c]);
                    codigoMorse.Append(" ");
                }
            }

            Console.WriteLine("El código Morse correspondiente es:");
            Console.WriteLine(codigoMorse.ToString());
        }

        private static void MorseATexto()
        {
            Console.WriteLine("Ingrese el código Morse a convertir a texto:");
            string codigoMorse = Console.ReadLine();

            StringBuilder texto = new StringBuilder();
            string[] palabras = codigoMorse.Split('/');
            foreach (string palabra in palabras)
            {
                string[] letras = palabra.Trim().Split(' ');
                foreach (string letra in letras)
                {
                    foreach (KeyValuePair<char, string> entry in codigoMorseDiccionario)
                    {
                        if (entry.Value == letra)
                        {
                            texto.Append(entry.Key);
                            break;
                        }
                    }
                }
                texto.Append(" ");
            }

            Console.WriteLine("El texto correspondiente es:");
            Console.WriteLine(texto.ToString());
        }
    }
}
