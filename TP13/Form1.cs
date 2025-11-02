using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP13
{
    public partial class Form1 : Form
    {
        INICIAR_SESION ventanaIniciar;
        Registrarse ventanaRegistro;
        public Form1()
        {
            InitializeComponent();
            ventanaRegistro = new Registrarse();
        }

        private void btnINICIAR_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ventanaRegistro.referenciarForm1Anterior(this);
            ventanaRegistro.Visible = true;
        }
    }
}
