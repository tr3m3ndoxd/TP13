using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP13
{
    public partial class Registrarse : Form
    {
        Form1 ventanaForm1;
        INICIAR_SESION ventanaIniciar;
        public Registrarse()
        {
            InitializeComponent();
            ventanaIniciar = new INICIAR_SESION();
        }
        public void referenciarForm1Anterior(Form1 ventanaForm1)
        {
            this.ventanaForm1 = ventanaForm1;
        }
        private void Registrarse_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ventanaForm1.Visible = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text != "")
                {
                    if (txtCrear.Text != "")
                    {
                        if (txtConfirmar.Text != "")
                        {
                            if (txtCrear.Text == txtConfirmar.Text)
                            {
                                string usuario = txtUsuario.Text;
                                string contraseña = txtCrear.Text;
                                ventanaIniciar.obtenrDatosdeRegis(usuario, contraseña);
                                MessageBox.Show("Registro existoso, inicie sesion", "Registro exiitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtUsuario = "";
                                txtCrear = "";
                                txtConfirmar = "";
                            }
                            else
                            {
                                MessageBox.Show("La Contraseña no coincide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Su constraseña no coincide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Porfavor agregue una contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show ("Porfavor agregue el nombre de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ventanaIniciar.referenciarVentanaAnterior (this);
            ventanaIniciar.Visible = true;
        }
    }
}
