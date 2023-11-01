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
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validar los datos aquí, por ejemplo, asegurarse de que los campos no estén vacíos.

            // Capturar datos del formulario
            string nombre = textBox1.Text;
            string Descripcion = textBox2.Text;
            string Cantidad = textBox3.Text;
            string Precio = textBox4.Text;

            // Agregar los datos a la DataGridView
            dataGridView1.Rows.Add(nombre,Descripcion,Cantidad,Precio);

            // Limpiar los campos del formulario
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
           
        }
    }
}
