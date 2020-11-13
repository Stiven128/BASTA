using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_Cliente
{
    public partial class Form1 : Form
    {
        public string Jugador;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form3 abrir = new Form3();
            abrir.Jugador = textBox1.Text;
            abrir.Show();
        }
    }
}
