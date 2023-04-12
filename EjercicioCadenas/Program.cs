using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCadenas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string entradaUsuario = PedirCadena();

            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine();
                Console.WriteLine("___ MENU ___");
                Console.WriteLine("Teclee el número con la opción deseada:");
                Console.WriteLine("1. Sustituir una palabra por otra en una cadena de texto");
                Console.WriteLine("2. Buscar texto en una cadena de texto");
                Console.WriteLine("3. Buscar texto de inicio en una cadena de texto");
                Console.WriteLine("4. Rellena con 'ceros'");

                int opcion = PedirOpcion();

                switch (opcion)
                {
                    case 1:
                        Sustituir(entradaUsuario);
                        break;
                    case 2:
                        Buscar(entradaUsuario);
                        break;
                    case 3:
                        BuscarInicioTexto(entradaUsuario);
                        break;
                    case 4:
                        ConvierteACeros();
                        break;
                }
                Console.WriteLine();
                Console.Write("¿Desea continuar? (S/N)");
                char respuesta = Console.ReadKey().KeyChar;
                continuar = (respuesta == 'S' || respuesta == 's');
                Console.WriteLine();
            }


        }
        static string PedirCadena()
        {
            string entrada;
            do
            {
                Console.WriteLine("Introduce una cadena que tenga mínimo 40 caracteres: ");
                entrada = Console.ReadLine();
                if (entrada.Length < 40)
                {
                    Console.WriteLine($"La cadena introducide tiene {entrada.Length} caracteres, por favor, " +
                        $"introduzca de nuevo otra cadena que tenga mínimo 40");
                }
            } while (entrada.Length < 40);

            return entrada;
        }

        static int PedirOpcion()
        {
            int opcionUsuario;

            do
            {
                Console.WriteLine("Elija una opción del 1-4");
            } while (!int.TryParse(Console.ReadLine(), out opcionUsuario) || opcionUsuario<1 || opcionUsuario>4);
            return opcionUsuario;

        }

        public static void Sustituir( string entradaUsuario)
        {
            Console.Write("Introduzca la palabra a sustituir y la sustituta separada por espacio: ");
            string[] reemplazar = Console.ReadLine().Split();
            string reemplazado = entradaUsuario.Replace(reemplazar[0], reemplazar[1]);
            Console.WriteLine($"Resultado: {reemplazado}");
          
         
        }

        public static void Buscar(string entradaUsuario)
        {
            Console.Write("Introduce el texto a buscar:");
            string buscarTexto=Console.ReadLine();
            if (entradaUsuario.Contains(buscarTexto))
            {
                Console.WriteLine($"El texto '{buscarTexto}' está en la cadena");
            } else
            {
                Console.WriteLine($"El texto '{buscarTexto}' no está en la cadena");
            }
          
            
        }

        public static void BuscarInicioTexto(string entradaUsuario)
        {
            Console.Write("Introduce el texto de inicio de la cadena a buscar: ");
            string inicio=Console.ReadLine();
            if (entradaUsuario.StartsWith(inicio))
            {
                Console.WriteLine($"La cadena comienza con '{inicio}'");
            } else
            {
                Console.WriteLine($"La cadena no comienza con '{inicio}'");
            }
           
        }

        public static void ConvierteACeros()
        {
            Console.Write("Introduce un dígito: ");
            string digito = Console.ReadLine();
            Console.WriteLine();
            int longitud = digito.Length;

            for (int i = 0;i < 12 - longitud;i++)
            {
                digito = "0" + digito;
            }
            Console.WriteLine(digito);
            
        }
    }
}
