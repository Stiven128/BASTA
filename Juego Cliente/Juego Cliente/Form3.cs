﻿using System;
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
    public partial class Form3 : Form
    {
        public string Jugador;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

          
                Form2 abrir = new Form2();
                abrir.IP = textBox1.Text;
                abrir.Jugador = Jugador;
            abrir.Show();
            
        }
    }
}
