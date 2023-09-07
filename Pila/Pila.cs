using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pila
{
    internal class Pila
    {
        private Nodo ultimoNodo;
        public Nodo UltimoNodo()
        {
            return ultimoNodo;
        }
        public void Apilar(Nodo newNodo)
        {
            if (ultimoNodo == null)
            {
                ultimoNodo = newNodo;
            }
            else
            {
                Nodo ultNodo = ultimoNodo;
                ultimoNodo = newNodo;
                ultimoNodo.Siguiente = ultNodo;
            }
        }
        public void Desapiilar()
        {
            Console.Clear();
            if(ultimoNodo == null)
            {
                Console.WriteLine("// The stack is empty");
                Console.ReadKey();
                Console.Clear();
                return;
               
            }
            ultimoNodo = ultimoNodo.Siguiente;
            MostrarPila();
            
        }

        public void MostrarPila()
        {
            Console.Clear();

            if(ultimoNodo == null)
            {
                Console.WriteLine("// The stack is empty");
                Console.ReadKey();
                Console.Clear();
                return;
               
            }

            MostrarNodo(ultimoNodo);
        }

        public void MostrarNodo(Nodo nNodo)
        {
            Console.WriteLine(nNodo.Numero);

            if(nNodo.Siguiente != null)
            {
                MostrarNodo(nNodo.Siguiente);
            }
        }
    }
}