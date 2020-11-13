using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego
{
    public partial class Form2 : Form
    {
        public string IP;
        char letra;
        private int _countDown = 0; // Seconds 
        private System.Windows.Forms.Timer _timer;
        static readonly object _lock = new object();
        static readonly Dictionary<int, TcpClient> list_clients = new Dictionary<int, TcpClient>();


        public Form2()
        {
            InitializeComponent();
        }

        private char LetraAlt()
        {
            Random rand = new Random();

            int numero = rand.Next(26);

             letra = (char)(((int)'A') + numero);

            return letra;
        }

        private void btnLetra_Click(object sender, EventArgs e)
        {
            txtLetra.Text = LetraAlt().ToString();
            dataGridView1.Rows.Add();
            
        }

        private void btnBasta_Click(object sender, EventArgs e)
        {
            _countDown = 0;
            CR();
        }
        private void CR()
        {

            _timer = new System.Windows.Forms.Timer();
            _timer.Tick += new EventHandler(timer1_Tick);
            _timer.Interval = 1000;
            _timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _countDown++;
            if (_countDown > 10)
            {
                label4.Text = "Basta!";


            }
            else {
                label4.Text = "Basta: " +_countDown.ToString(); }
        }
        public static void handle_clients(object o)
        {
            int id = (int)o;
            TcpClient client;

            lock (_lock) client = list_clients[id];

            while (true)
            {
                NetworkStream stream = client.GetStream();
                byte[] buffer = new byte[1024];
                int byte_count = stream.Read(buffer, 0, buffer.Length);

                if (byte_count == 0)
                {
                    break;
                }

                string data = Encoding.ASCII.GetString(buffer, 0, byte_count);
                broadcast(data);
                Console.WriteLine(data);
            }

            lock (_lock) list_clients.Remove(id);
            client.Client.Shutdown(SocketShutdown.Both);
            client.Close();
        }

        public static void broadcast(string data)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(data + Environment.NewLine);

            lock (_lock)
            {
                foreach (TcpClient c in list_clients.Values)
                {
                    NetworkStream stream = c.GetStream();

                    stream.Write(buffer, 0, buffer.Length);
                }
            }
        }
            private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 1;

            TcpListener ServerSocket = new TcpListener(IPAddress.Any, 5000);
            ServerSocket.Start();

            while (true)
            {
                TcpClient client = ServerSocket.AcceptTcpClient();
                lock (_lock) list_clients.Add(count, client);
                Console.Write("Someone connected!!");

                Thread t = new Thread(handle_clients);
                t.Start(count);
                count++;
            }

        }
      
    }
}
