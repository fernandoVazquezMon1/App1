using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class nuevoregis : Form
    {
        public nuevoregis()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            registrar registrar = new registrar();
            registrar.Show();
            string nombreUsuario = textBoxnombre.Text;
            string apellido = textBoxapellido.Text;
            string correoElectronico = textBoxemail.Text;
            string contrasena = textBoxcontraseña.Text;

            // Validar la información
            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(correoElectronico) || string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                ;
            }

            // Aquí puedes implementar la lógica para guardar la información en una base de datos o archivo.

            // Mostrar mensaje de registro exitoso
            MessageBox.Show("Registro exitoso.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar los campos después del registro exitoso
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            textBoxnombre.Text = "";
            textBoxapellido.Text = "";
            textBoxemail.Text = "";
            textBoxcontraseña.Text = "";
        }
    }
}

