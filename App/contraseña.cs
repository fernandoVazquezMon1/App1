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
    public partial class contraseña : Form
    {
        public contraseña()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nuevaContraseña = textBox1.Text;

            // Realiza la validación de la contraseña aquí
            if (nuevaContraseña.Length >= 8)
            {
                // Aquí guardarías la nueva contraseña en la base de datos o en otro lugar
                // Por ejemplo, puedes usar una base de datos o una variable para almacenarla
                // Luego, puedes mostrar un mensaje de éxito al usuario.
                MessageBox.Show("Contraseña restablecida con éxito.");
                registrar registrar = new registrar();
                registrar.Show();
            }
           
            else
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres.");
            }
        }
    }
}
