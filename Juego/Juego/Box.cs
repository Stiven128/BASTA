using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    class Box
    {
        public TcpClient c;
        public Dictionary<int, TcpClient> list;

        public Box(TcpClient c, Dictionary<int, TcpClient> list)
        {
            this.c = c;
            this.list = list;
        }
    }
}
