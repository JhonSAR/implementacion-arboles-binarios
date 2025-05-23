using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Fase4JhonArdila
{
    internal class ArbolBinario
    {
        public Nodo Raiz;

        public void AgregarNodo(int valor)
        {
            Raiz = AgregarNodoRecursivo(Raiz, valor);
        }

        private Nodo AgregarNodoRecursivo(Nodo raiz, int valor) 
        {
            if (raiz == null)
            {
                raiz = new Nodo(valor);
                return raiz;
            }

            if(valor > raiz.valorEntero)
            {
                raiz.nodoDerecho = AgregarNodoRecursivo(raiz.nodoDerecho, valor);
            } 
            else
            {
                raiz.nodoIzquierdo = AgregarNodoRecursivo(raiz.nodoIzquierdo, valor);
            }

            return raiz;
        }

        public void GraficarArbol(Graphics grafica, Nodo nodo, int x, int y, int distanciaX, int distanciaY)
        {
            if (nodo == null)
            {
                return;
            }
            else
            {
                Pen pen = new Pen(Color.Black);
                Brush brush = new SolidBrush(Color.LightBlue);
                Brush fontBrush = new SolidBrush(Color.Black);
                Font font = new Font("Arial", 10);

                int radio = 20;

                // Para que se dibuje el nodo
                grafica.FillEllipse(brush, x - radio, y - radio, 2 * radio, 2 * radio);
                grafica.DrawEllipse(pen, x - radio, y - radio, 2 * radio, 2 * radio);
                grafica.DrawString(nodo.valorEntero.ToString(), font, fontBrush, x - 10, y - 10);

                // Para que se dibujen los conectores y sus nodos hijos
                if (nodo.nodoDerecho != null)
                {
                    grafica.DrawLine(pen, x, y, x + distanciaX, y + distanciaY);
                    GraficarArbol(grafica, nodo.nodoDerecho, x + distanciaX, y + distanciaY, distanciaX / 2, distanciaY);
                }

                if (nodo.nodoIzquierdo != null)
                {
                    grafica.DrawLine(pen, x, y, x - distanciaX, y + distanciaY);
                    GraficarArbol(grafica, nodo.nodoIzquierdo, x - distanciaX, y + distanciaY, distanciaX / 2, distanciaY);
                }
            }
        }

        public List<int> ObtenerPreorden(Nodo nodo)
        {
            List<int> resultado = new List<int>();
            ListaPreorden(nodo,  resultado);
            return resultado;
        }

        private void ListaPreorden(Nodo nodo,  List<int> resultado)
        {
            if (nodo != null)
            {
                resultado.Add(nodo.valorEntero);
                ListaPreorden(nodo.nodoIzquierdo, resultado);
                ListaPreorden(nodo.nodoDerecho, resultado);
            }
        }

        public void DibujarPreorden(Graphics grafica, List<int> listaPreorden, int x, int y, int distanciaX)
        {
            Pen pen = new Pen(Color.Black);
            Brush brush = new SolidBrush(Color.LightBlue);
            Brush fontBrush = new SolidBrush(Color.Black);
            Font font = new Font("Arial", 10);

            int radio = 20;

            for (int i = 0; i < listaPreorden.Count; i++)
            {
                int valor = listaPreorden[i];
                int posicionX = x + i * distanciaX;

                // Para que se dibuje el nodo
                grafica.FillEllipse(brush,posicionX - radio, y - radio, 2 * radio, 2 * radio);
                grafica.DrawEllipse(pen, posicionX - radio, y - radio, 2 * radio, 2 * radio);
                grafica.DrawString(valor.ToString(), font, fontBrush, posicionX - 10, y - 10);
            }            
        }

        public List<int> ObtenerInorden(Nodo nodo)
        {
            List<int> resultado = new List<int>();
            ListaInorden(nodo, resultado);
            return resultado;
        }

        private void ListaInorden(Nodo nodo, List<int> resultado)
        {
            if (nodo != null)
            {
                ListaInorden(nodo.nodoIzquierdo, resultado);
                resultado.Add(nodo.valorEntero);
                ListaInorden(nodo.nodoDerecho, resultado);
            }
        }

        public void DibujarInorden(Graphics grafica, List<int> listaInorden, int x, int y, int distanciaX)
        {
            Pen pen = new Pen(Color.Black);
            Brush brush = new SolidBrush(Color.LightBlue);
            Brush fontBrush = new SolidBrush(Color.Black);
            Font font = new Font("Arial", 10);

            int radio = 20;

            for (int i = 0; i < listaInorden.Count; i++)
            {
                int valor = listaInorden[i];
                int posicionX = x + i * distanciaX;

                // Para que se dibuje el nodo
                grafica.FillEllipse(brush, posicionX - radio, y - radio, 2 * radio, 2 * radio);
                grafica.DrawEllipse(pen, posicionX - radio, y - radio, 2 * radio, 2 * radio);
                grafica.DrawString(valor.ToString(), font, fontBrush, posicionX - 10, y - 10);
            }
        }

        public List<int> ObtenerPosorden(Nodo nodo)
        {
            List<int> resultado = new List<int>();
            ListaPosorden(nodo, resultado);
            return resultado;
        }

        private void ListaPosorden(Nodo nodo, List<int> resultado)
        {
            if (nodo != null)
            {
                ListaPosorden(nodo.nodoIzquierdo, resultado);
                ListaPosorden(nodo.nodoDerecho, resultado);
                resultado.Add(nodo.valorEntero);
            }
        }

        public void DibujarPosorden(Graphics grafica, List<int> listaPosorden, int x, int y, int distanciaX)
        {
            Pen pen = new Pen(Color.Black);
            Brush brush = new SolidBrush(Color.LightBlue);
            Brush fontBrush = new SolidBrush(Color.Black);
            Font font = new Font("Arial", 10);

            int radio = 20;

            for (int i = 0; i < listaPosorden.Count; i++)
            {
                int valor = listaPosorden[i];
                int posicionX = x + i * distanciaX;

                // Para que se dibuje el nodo
                grafica.FillEllipse(brush, posicionX - radio, y - radio, 2 * radio, 2 * radio);
                grafica.DrawEllipse(pen, posicionX - radio, y - radio, 2 * radio, 2 * radio);
                grafica.DrawString(valor.ToString(), font, fontBrush, posicionX - 10, y - 10);
            }
        }
    }
}
