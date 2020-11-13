using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego
{
    public partial class Form1 : Form
    {
        string Ip;
        public Form1()
        {
            InitializeComponent();
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 abrir = new Form2();
            abrir.IP = GetLocalIPAddress();
            abrir.label1.Text = textBox1.Text;
            abrir.label3.Text = GetLocalIPAddress();
            abrir.Show();
            Ip = GetLocalIPAddress();

        }
    }
}
