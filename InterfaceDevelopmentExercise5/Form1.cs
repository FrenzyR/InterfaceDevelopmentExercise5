using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceDevelopmentExercise5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cogemos el mensaje que pusimos en el textBox y lo pasamos a string
            string newTitle = textBox1.Text;
            // Creamos el messageBox
            DialogResult result = MessageBox.Show(
                "¿Desea poner el siguiente texto como título del formulario principal?\n\n" + newTitle,
                "Confirmar Cambio de Título",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Text = newTitle;
            }
        }
    }
}
