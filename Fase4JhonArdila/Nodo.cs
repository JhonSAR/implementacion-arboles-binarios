using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase4JhonArdila
{
    internal class Nodo
    {
        public int valorEntero;
        public Nodo nodoDerecho;
        public Nodo nodoIzquierdo;
        
        public Nodo(int valor) 
        {
            valorEntero = valor;
            nodoDerecho = nodoIzquierdo = null;

        }
    }
}
