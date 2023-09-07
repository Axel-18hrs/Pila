using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pila
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pila pila = new Pila();
            bool salir = true;

            while (salir)
            {
                Console.WriteLine("// Select an option" +
                    "\n[1]: Enter a value " +
                    "\n[2]: Delete a value" +
                    "\n[3]: Show stack" +
                    "\n[4]: Exit");

                int opcion;

                try
                {
                    opcion = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.Clear();
                    continue;
                }

                switch (opcion)
                {

                    case 1:
                        Console.Clear();
                        Console.WriteLine("Enter a value:");
                        Nodo nodo = new Nodo();
                        nodo.Numero = Convert.ToInt16(Console.ReadLine());
                        pila.Apilar(nodo);
                        break;

                    case 2:
                        Console.Clear();
                        pila.Desapiilar();

                        break;

                    case 3:
                        pila.MostrarPila();
                        break;

                    case 4:
                        salir = false;
                        Console.Clear();
                        Console.WriteLine("Good bye <3");
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
