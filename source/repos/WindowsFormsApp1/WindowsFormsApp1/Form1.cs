using BibliotecaIcesi;
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        Biblioteca b;

        public Form1()
        {
            InitializeComponent();
            b = new Biblioteca();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            b.agregarLibro(Convert.ToDouble(NOMBRE.Text));
        }

        private void TOTAL_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EL PESO DE LOS LIBROS ES: " + b.pesos());
        }
    }
}
