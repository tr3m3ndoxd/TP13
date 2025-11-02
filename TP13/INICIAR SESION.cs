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
    public partial class INICIAR_SESION : Form
    {
        Registrarse ventanaRegistrarse;
        string userRegis;
        string passRegis;
        public INICIAR_SESION()
        {
            InitializeComponent();
        }
        public void obtenrDatosdeRegis(string usuario, string contraseña)
        {
            userRegis = usuario;
            passRegis = contraseña;
        }
        public void referenciarVentanaAnterior(Registrarse ventanaRegistrarse)
        {
            this.ventanaRegistrarse = ventanaRegistrarse;
        }
        private void btnVOLVER_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ventanaRegistrarse.Visible = true;
        }

        private void INICIAR_SESION_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(Username.Text != "")
                {
                    if (Contraseña.Text !="")
                    {
                        if (Username.Text == userRegis)
                        {
                            if (Contraseña.Text == passRegis)
                            {
                                this.Visible = false;

                            }
                            else
                            {
                                MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("El nombre de usuario no existe, porfavor registrate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Porfavor ingrese la contarseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Porfavor agregue el nombre de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception    Error)
            {
                MessageBox.Show("Error: " + Error);
            }
        }
    }
}
