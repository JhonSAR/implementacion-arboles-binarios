using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase4JhonArdila
{
    public partial class frmEsctructuraArbolBinario : Form
    {
        ArbolBinario arbolBinario = new ArbolBinario();

        public frmEsctructuraArbolBinario()
        {
            InitializeComponent();
            panelArbol.Paint += new PaintEventHandler(panelArbol_Paint);
            panelPreorden.Paint += new PaintEventHandler(panelPreorden_Paint);
            panelInorden.Paint += new PaintEventHandler(panelInorden_Paint);
            panelPosorden.Paint += new PaintEventHandler(panelPosorden_Paint);
        }

        private void frmEsctructuraArbolBinario_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarNodo_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValorEntero.Text, out int valor))
            {
                arbolBinario.AgregarNodo(valor);
                txtValorEntero.Clear();
                txtValorEntero.Focus();
                panelArbol.Invalidate();
                panelPreorden.Invalidate();
                panelInorden.Invalidate();
                panelPosorden.Invalidate();
            }
            else
            {
                MessageBox.Show("Valor ingresado no válido.");
                txtValorEntero.Clear();
                txtValorEntero.Focus();
            }
        }

        private void panelArbol_Paint(object sender, PaintEventArgs e)
        {
            Graphics grafica = e.Graphics;
            arbolBinario.GraficarArbol(grafica, arbolBinario.Raiz, panelArbol.Width / 2, 20, panelArbol.Width / 4, 50);
        }

        private void panelPreorden_Paint(object sender, PaintEventArgs e)
        {
            Graphics grafica = e.Graphics;
            List<int> listaPreorden = arbolBinario.ObtenerPreorden(arbolBinario.Raiz);
            arbolBinario.DibujarPreorden(grafica, listaPreorden, 20, panelPreorden.Height / 2, 50);
        }

        private void panelInorden_Paint(object sender, PaintEventArgs e)
        {
            Graphics grafica = e.Graphics;
            List<int> listaInorden = arbolBinario.ObtenerInorden(arbolBinario.Raiz);
            arbolBinario.DibujarInorden(grafica, listaInorden, 20, panelInorden.Height / 2, 50);
        }

        private void panelPosorden_Paint(object sender, PaintEventArgs e)
        {
            Graphics grafica = e.Graphics;
            List<int> listaPosorden = arbolBinario.ObtenerPosorden(arbolBinario.Raiz);
            arbolBinario.DibujarPosorden(grafica, listaPosorden, 20, panelPosorden.Height / 2, 50);
        }

        private void txtValorEntero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
