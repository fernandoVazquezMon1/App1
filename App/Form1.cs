using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Fernando Vazquez montaño
namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // Obtén el usuario y la contraseña ingresados por el usuario
            string usuario = textBoxUsuario.Text;
            string contraseña = textBoxContraseña.Text;

            // Realiza la validación (puedes personalizar esta parte)
            if (usuario == "Fernando" && contraseña == "287011")
            {
                // Acceso concedido, muestra un mensaje y realiza las acciones necesarias
                labelMensaje.Text = "Acceso concedido. Bienvenido, " + usuario + "!";
                registrar registrar = new registrar();
                registrar.Show();
            }
            else
            {
                
                // Acceso denegado, muestra un mensaje de error
                labelMensaje.Text = "Acceso denegado. Por favor, verifica tus datos.";

               
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            nuevoregis nuevoregis = new nuevoregis();
            nuevoregis.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            contraseña contraseña = new contraseña();
            contraseña.Show();
        }
    }
}
