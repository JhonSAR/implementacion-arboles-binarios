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
    public partial class Form1 : Form
    {
        private const string CONTRASENIA = "UNAD";
        private ErrorProvider error;

        public Form1()
        {
            InitializeComponent();
            error = new ErrorProvider();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string contrasenia = "";

            contrasenia = this.txtContrasenia.Text.Trim();

            if (contrasenia == "")
            {
                this.error.SetError(this.txtContrasenia, "¡Ingrese una contraseña!");
                this.txtContrasenia.Focus();
            }
            else
            {
                if (contrasenia != CONTRASENIA)
                {
                    this.error.SetError(this.txtContrasenia, "¡La contraseña ingresada es incorrecta!");
                    this.txtContrasenia.Focus();
                }
                else
                {
                    this.error.SetError(this.txtContrasenia, null);
                    frmEsctructuraArbolBinario esctructuraArbolBinario = new frmEsctructuraArbolBinario();
                    esctructuraArbolBinario.Show();
                    this.Hide();
                }
            }
        }
    }
}
